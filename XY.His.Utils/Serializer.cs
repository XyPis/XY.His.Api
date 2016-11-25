using System.Data;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace XY.His.Utils
{
    public static class Serializer
    {
        public static byte[] SerializeBinary(object[] obj)
        {
            if (obj == null || obj.Length == 0)
                return new byte[] {};

            for (int i = 0; i < obj.Length; i++)
            {
                if (obj[i] != null)
                {
                    if (obj[i] is DataSet)
                        obj[i] = new DataSetSurrogate((DataSet) obj[i]);
                    else if(obj[i] is DataTable)
                        obj[i] = new DataTableSurrogate((DataTable)obj[i]);
                }
            }
            BinaryFormatter se = new BinaryFormatter();
            MemoryStream memStream = new MemoryStream();
            se.Serialize(memStream, obj);
            byte[] bobj = memStream.ToArray();
            memStream.Close();
            return bobj;
        }
      
        public static object[] DeserializeBinary(byte[] bobj)
        {
            if (bobj == null || bobj.Length == 0)
                return new object[] {};

            MemoryStream memStream = new MemoryStream(bobj);
            memStream.Position = 0;
            BinaryFormatter de = new BinaryFormatter();
            object[] newobj = null;
            newobj = (object[]) de.Deserialize(memStream);
            memStream.Close();

            for (int i = 0; i < newobj.Length; i++)
            {
                if (newobj[i] != null)
                {
                    if(newobj[i] is DataSetSurrogate)
                        newobj[i] = ((DataSetSurrogate) newobj[i]).ConvertToDataSet();
                    else if (newobj[i] is DataTableSurrogate)
                        newobj[i] = ((DataTableSurrogate)newobj[i]).ConvertToDataTable();
                }
            }

            return newobj;
        }
    }
}