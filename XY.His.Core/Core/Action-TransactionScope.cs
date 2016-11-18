
public bool Execute(Func<bool> function)
{
    bool result = false;

    try
    {
        using (TransactionScope transactionScope = new TransactionScope())
        {
            try
            {
                if (function())
                {
                    // The function was successful, so we can save all 
                    // changes and complete the transaction.
                    result = SaveChanges();

                    if (result)
                    {
                        try
                        {
                            transactionScope.Complete();
                        }
                        catch (InvalidOperationException)
                        {
                            result = false;
                        }
                    }
                }
                else
                {
                    // Function failed.
                }
            }
            catch (EntityCommandExecutionException)
            {
                // A command (stored procedure) failed to execute.
            }
            catch (Exception)
            {
                // An unspecified exception occurred.
            }
        }
    }
    catch (TransactionAbortedException e)
    {
        // Transaction is aborted.
    }
    catch (TransactionInDoubtException e)
    {
        // Transaction is in doubt.
    }
}