using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using XY.His.Model.Models.Mapping;

namespace XY.His.Model.Models
{
    public partial class HISContext : DbContext
    {
        static HISContext()
        {
            Database.SetInitializer<HISContext>(null);
        }

        public HISContext()
            : base("Name=HISContext")
        {
        }

        public DbSet<aa1> aa1 { get; set; }
        public DbSet<AdviceAuthDtl> AdviceAuthDtls { get; set; }
        public DbSet<BaseTableRole> BaseTableRoles { get; set; }
        public DbSet<bb1> bb1 { get; set; }
        public DbSet<BKStoreLog> BKStoreLogs { get; set; }
        public DbSet<BsAddrssCommitt> BsAddrssCommitts { get; set; }
        public DbSet<BsAnaeItem> BsAnaeItems { get; set; }
        public DbSet<BsAnae> BsAnaes { get; set; }
        public DbSet<BsArea> BsAreas { get; set; }
        public DbSet<BsAreaCommittee> BsAreaCommittees { get; set; }
        public DbSet<BsAreaPoliceStation> BsAreaPoliceStations { get; set; }
        public DbSet<BsAreaProvince> BsAreaProvinces { get; set; }
        public DbSet<BsAreaRegion> BsAreaRegions { get; set; }
        public DbSet<BsBacteria> BsBacterias { get; set; }
        public DbSet<BsBacteriaDrug> BsBacteriaDrugs { get; set; }
        public DbSet<BsBacteriaGram> BsBacteriaGrams { get; set; }
        public DbSet<BsBacteriaShu> BsBacteriaShus { get; set; }
        public DbSet<BsBacteriaStandType> BsBacteriaStandTypes { get; set; }
        public DbSet<BsBacteriaType> BsBacteriaTypes { get; set; }
        public DbSet<BsBase> BsBases { get; set; }
        public DbSet<BsBaseCheck> BsBaseChecks { get; set; }
        public DbSet<BsBaseCure> BsBaseCures { get; set; }
        public DbSet<BsBaseDrug> BsBaseDrugs { get; set; }
        public DbSet<BsBaseNurse> BsBaseNurses { get; set; }
        public DbSet<BsBed> BsBeds { get; set; }
        public DbSet<BsBranch> BsBranches { get; set; }
        public DbSet<BsCareGroup> BsCareGroups { get; set; }
        public DbSet<BsCertificate> BsCertificates { get; set; }
        public DbSet<BsCommitteeRoad> BsCommitteeRoads { get; set; }
        public DbSet<BsCompany> BsCompanies { get; set; }
        public DbSet<BsCountry> BsCountries { get; set; }
        public DbSet<BsDeptType> BsDeptTypes { get; set; }
        public DbSet<BsDiagRoom> BsDiagRooms { get; set; }
        public DbSet<BsDocLevel> BsDocLevels { get; set; }
        public DbSet<BsDocRegType> BsDocRegTypes { get; set; }
        public DbSet<BSDOCREGTYPE_TEMP_> BSDOCREGTYPE_TEMP_ { get; set; }
        public DbSet<BsDoctor> BsDoctors { get; set; }
        public DbSet<BsDoctorBack> BsDoctorBacks { get; set; }
        public DbSet<BsDrugForm> BsDrugForms { get; set; }
        public DbSet<BsDrugFormUnit> BsDrugFormUnits { get; set; }
        public DbSet<BsDrugFormUsage> BsDrugFormUsages { get; set; }
        public DbSet<BsEducation> BsEducations { get; set; }
        public DbSet<BsEducationIll> BsEducationIlls { get; set; }
        public DbSet<BsEduLevel> BsEduLevels { get; set; }
        public DbSet<BsEqType> BsEqTypes { get; set; }
        public DbSet<BsExecLocation> BsExecLocations { get; set; }
        public DbSet<BsFamily> BsFamilies { get; set; }
        public DbSet<BsFeeType> BsFeeTypes { get; set; }
        public DbSet<BsFeeTypeSub> BsFeeTypeSubs { get; set; }
        public DbSet<BsFixCharge> BsFixCharges { get; set; }
        public DbSet<BsFluid> BsFluids { get; set; }
        public DbSet<BsFrequency> BsFrequencies { get; set; }
        public DbSet<BsFrequencyTime> BsFrequencyTimes { get; set; }
        public DbSet<BsFromHospital> BsFromHospitals { get; set; }
        public DbSet<BsGfxe> BsGfxes { get; set; }
        public DbSet<BsGroup> BsGroups { get; set; }
        public DbSet<BsGroupSub> BsGroupSubs { get; set; }
        public DbSet<BsGroupSub2> BsGroupSub2 { get; set; }
        public DbSet<BsHealthEduRec> BsHealthEduRecs { get; set; }
        public DbSet<BsHospital> BsHospitals { get; set; }
        public DbSet<BsHouse> BsHouses { get; set; }
        public DbSet<BsHsFeety> BsHsFeeties { get; set; }
        public DbSet<BsIllness> BsIllnesses { get; set; }
        public DbSet<BsIllness0> BsIllness0 { get; set; }
        public DbSet<BsIllness177> BsIllness177 { get; set; }
        public DbSet<BsIllness178> BsIllness178 { get; set; }
        public DbSet<BsIllness179> BsIllness179 { get; set; }
        public DbSet<BsIllness180> BsIllness180 { get; set; }
        public DbSet<BsIllness181> BsIllness181 { get; set; }
        public DbSet<BsIllness182> BsIllness182 { get; set; }
        public DbSet<BsIllness183> BsIllness183 { get; set; }
        public DbSet<BsIllness184> BsIllness184 { get; set; }
        public DbSet<BsIllness185> BsIllness185 { get; set; }
        public DbSet<BsIllness186> BsIllness186 { get; set; }
        public DbSet<BsIllness187> BsIllness187 { get; set; }
        public DbSet<BsIllness188> BsIllness188 { get; set; }
        public DbSet<BsIllness189> BsIllness189 { get; set; }
        public DbSet<BsIllness190> BsIllness190 { get; set; }
        public DbSet<BsIllness191> BsIllness191 { get; set; }
        public DbSet<BsIllness192> BsIllness192 { get; set; }
        public DbSet<BsIllness193> BsIllness193 { get; set; }
        public DbSet<BsIllness194> BsIllness194 { get; set; }
        public DbSet<BsIllness195> BsIllness195 { get; set; }
        public DbSet<BsIllness196> BsIllness196 { get; set; }
        public DbSet<BsIllness197> BsIllness197 { get; set; }
        public DbSet<BsIllness198> BsIllness198 { get; set; }
        public DbSet<BsIllness199> BsIllness199 { get; set; }
        public DbSet<BsIllness200> BsIllness200 { get; set; }
        public DbSet<BsIllness201> BsIllness201 { get; set; }
        public DbSet<BsIllness202> BsIllness202 { get; set; }
        public DbSet<BsIllness203> BsIllness203 { get; set; }
        public DbSet<BsIllness204> BsIllness204 { get; set; }
        public DbSet<BsIllness205> BsIllness205 { get; set; }
        public DbSet<BsIllness206> BsIllness206 { get; set; }
        public DbSet<BsIllness207> BsIllness207 { get; set; }
        public DbSet<BsIllness208> BsIllness208 { get; set; }
        public DbSet<BsIllness209> BsIllness209 { get; set; }
        public DbSet<BsIllness210> BsIllness210 { get; set; }
        public DbSet<BsIllness211> BsIllness211 { get; set; }
        public DbSet<BsIllness212> BsIllness212 { get; set; }
        public DbSet<BsIllness213> BsIllness213 { get; set; }
        public DbSet<BsIllness214> BsIllness214 { get; set; }
        public DbSet<BsIllness215> BsIllness215 { get; set; }
        public DbSet<BsIllness216> BsIllness216 { get; set; }
        public DbSet<BsIllness217> BsIllness217 { get; set; }
        public DbSet<BsIllness218> BsIllness218 { get; set; }
        public DbSet<BsIllness219> BsIllness219 { get; set; }
        public DbSet<BsIllness220> BsIllness220 { get; set; }
        public DbSet<BsIllness221> BsIllness221 { get; set; }
        public DbSet<BsIllness222> BsIllness222 { get; set; }
        public DbSet<BsIllness223> BsIllness223 { get; set; }
        public DbSet<BsIllness224> BsIllness224 { get; set; }
        public DbSet<BsIllness225> BsIllness225 { get; set; }
        public DbSet<BsIllness226> BsIllness226 { get; set; }
        public DbSet<BsIllness227> BsIllness227 { get; set; }
        public DbSet<BsIllness228> BsIllness228 { get; set; }
        public DbSet<BsIllness229> BsIllness229 { get; set; }
        public DbSet<BsIllness230> BsIllness230 { get; set; }
        public DbSet<BsIllness231> BsIllness231 { get; set; }
        public DbSet<BsIllness232> BsIllness232 { get; set; }
        public DbSet<BsIllness233> BsIllness233 { get; set; }
        public DbSet<BsIllness234> BsIllness234 { get; set; }
        public DbSet<BsIllness235> BsIllness235 { get; set; }
        public DbSet<BsIllness236> BsIllness236 { get; set; }
        public DbSet<BsIllness237> BsIllness237 { get; set; }
        public DbSet<BsIllness238> BsIllness238 { get; set; }
        public DbSet<BsIllness239> BsIllness239 { get; set; }
        public DbSet<BsIllness240> BsIllness240 { get; set; }
        public DbSet<BsIllness241> BsIllness241 { get; set; }
        public DbSet<BsIllness242> BsIllness242 { get; set; }
        public DbSet<BsIllness243> BsIllness243 { get; set; }
        public DbSet<BsIllness244> BsIllness244 { get; set; }
        public DbSet<BsIllness245> BsIllness245 { get; set; }
        public DbSet<BsIllness246> BsIllness246 { get; set; }
        public DbSet<BsIllness247> BsIllness247 { get; set; }
        public DbSet<BsIllness248> BsIllness248 { get; set; }
        public DbSet<BsIllness249> BsIllness249 { get; set; }
        public DbSet<BsIllness250> BsIllness250 { get; set; }
        public DbSet<BsIllness251> BsIllness251 { get; set; }
        public DbSet<BsIllness252> BsIllness252 { get; set; }
        public DbSet<BsIllness253> BsIllness253 { get; set; }
        public DbSet<BsIllness254> BsIllness254 { get; set; }
        public DbSet<BsIllness255> BsIllness255 { get; set; }
        public DbSet<BsIllness256> BsIllness256 { get; set; }
        public DbSet<BsIllness257> BsIllness257 { get; set; }
        public DbSet<BsIllness258> BsIllness258 { get; set; }
        public DbSet<BsIllness259> BsIllness259 { get; set; }
        public DbSet<BsInfection> BsInfections { get; set; }
        public DbSet<BsInfReason> BsInfReasons { get; set; }
        public DbSet<BsInfReasonType> BsInfReasonTypes { get; set; }
        public DbSet<BsInfSystem> BsInfSystems { get; set; }
        public DbSet<BsInfSystemType> BsInfSystemTypes { get; set; }
        public DbSet<BsInvInItem> BsInvInItems { get; set; }
        public DbSet<BsInvMzItem> BsInvMzItems { get; set; }
        public DbSet<BsItem> BsItems { get; set; }
        public DbSet<BsItemAttach> BsItemAttaches { get; set; }
        public DbSet<BSITEMCUSTOM> BSITEMCUSTOMs { get; set; }
        public DbSet<BSITEMCUSTOMGROUP> BSITEMCUSTOMGROUPs { get; set; }
        public DbSet<BsItemDrug> BsItemDrugs { get; set; }
        public DbSet<BsItemEquipment> BsItemEquipments { get; set; }
        public DbSet<BsItemFirstPage> BsItemFirstPages { get; set; }
        public DbSet<BsItemFrequency> BsItemFrequencies { get; set; }
        public DbSet<BsItemIllType> BsItemIllTypes { get; set; }
        public DbSet<BsItemItem> BsItemItems { get; set; }
        public DbSet<BsItemLocation> BsItemLocations { get; set; }
        public DbSet<BsItemName> BsItemNames { get; set; }
        public DbSet<BsItemNameMulti> BsItemNameMultis { get; set; }
        public DbSet<BsItemPac> BsItemPacs { get; set; }
        public DbSet<BsItemPatType> BsItemPatTypes { get; set; }
        public DbSet<BsItemPeople> BsItemPeoples { get; set; }
        public DbSet<BsItemPerson> BsItemPersons { get; set; }
        public DbSet<BsItemUnit> BsItemUnits { get; set; }
        public DbSet<BsItemUsage> BsItemUsages { get; set; }
        public DbSet<BsItemYb> BsItemYbs { get; set; }
        public DbSet<BsItemYbTip> BsItemYbTips { get; set; }
        public DbSet<BsJCGroup> BsJCGroups { get; set; }
        public DbSet<BsJCGroupAttach> BsJCGroupAttaches { get; set; }
        public DbSet<BsJCGroupItem> BsJCGroupItems { get; set; }
        public DbSet<BsLabSource> BsLabSources { get; set; }
        public DbSet<BsLabSourceItem> BsLabSourceItems { get; set; }
        public DbSet<BsLabSourceItem_0510> BsLabSourceItem_0510 { get; set; }
        public DbSet<BsLessonType> BsLessonTypes { get; set; }
        public DbSet<BsLimitDocLev> BsLimitDocLevs { get; set; }
        public DbSet<BsLimitGroup> BsLimitGroups { get; set; }
        public DbSet<BsLocation> BsLocations { get; set; }
        public DbSet<BsLocationRoomWindow> BsLocationRoomWindows { get; set; }
        public DbSet<BsLocBranch> BsLocBranches { get; set; }
        public DbSet<BsLocPatType> BsLocPatTypes { get; set; }
        public DbSet<BsLocSystem> BsLocSystems { get; set; }
        public DbSet<BsLocSystemSub> BsLocSystemSubs { get; set; }
        public DbSet<BsLocSystemSub2> BsLocSystemSub2 { get; set; }
        public DbSet<BsManufacturer> BsManufacturers { get; set; }
        public DbSet<BsMzFeety> BsMzFeeties { get; set; }
        public DbSet<BsNation> BsNations { get; set; }
        public DbSet<BsNew> BsNews { get; set; }
        public DbSet<BsnotYb> BsnotYbs { get; set; }
        public DbSet<BsOaGroup> BsOaGroups { get; set; }
        public DbSet<BsOaGroupSub> BsOaGroupSubs { get; set; }
        public DbSet<BsOP> BsOPS { get; set; }
        public DbSet<BsOpsItem> BsOpsItems { get; set; }
        public DbSet<BsOpsRoom> BsOpsRooms { get; set; }
        public DbSet<BsOuMergeFee> BsOuMergeFees { get; set; }
        public DbSet<BsPatFinger> BsPatFingers { get; set; }
        public DbSet<BsPatient> BsPatients { get; set; }
        public DbSet<BsPatientYBIll> BsPatientYBIlls { get; set; }
        public DbSet<BsPatIll> BsPatIlls { get; set; }
        public DbSet<BsPatMenuIndex> BsPatMenuIndexes { get; set; }
        public DbSet<BsPatType> BsPatTypes { get; set; }
        public DbSet<BsPatTypeLimit> BsPatTypeLimits { get; set; }
        public DbSet<BsPatTypeYbIll> BsPatTypeYbIlls { get; set; }
        public DbSet<BsPayWay> BsPayWays { get; set; }
        public DbSet<BsPosition> BsPositions { get; set; }
        public DbSet<BsPriceAdd> BsPriceAdds { get; set; }
        public DbSet<BsQuestion> BsQuestions { get; set; }
        public DbSet<BsRegPatAmount> BsRegPatAmounts { get; set; }
        public DbSet<BsRegSpanSub> BsRegSpanSubs { get; set; }
        public DbSet<BsRegTimeSpan> BsRegTimeSpans { get; set; }
        public DbSet<BsRegType> BsRegTypes { get; set; }
        public DbSet<BsRelation> BsRelations { get; set; }
        public DbSet<BsRoom> BsRooms { get; set; }
        public DbSet<BsRoomGroup> BsRoomGroups { get; set; }
        public DbSet<BsRoomWindow> BsRoomWindows { get; set; }
        public DbSet<BsScore> BsScores { get; set; }
        public DbSet<BsSex> BsSexes { get; set; }
        public DbSet<BsSpeciality> BsSpecialities { get; set; }
        public DbSet<BsSubject> BsSubjects { get; set; }
        public DbSet<BsTallyGroup> BsTallyGroups { get; set; }
        public DbSet<BsTallyType> BsTallyTypes { get; set; }
        public DbSet<BsTestPaper> BsTestPapers { get; set; }
        public DbSet<BsTubeType> BsTubeTypes { get; set; }
        public DbSet<BsUnit> BsUnits { get; set; }
        public DbSet<BsUnitRatio> BsUnitRatios { get; set; }
        public DbSet<BsUsage> BsUsages { get; set; }
        public DbSet<BsUsageItem> BsUsageItems { get; set; }
        public DbSet<BsUser> BsUsers { get; set; }
        public DbSet<BsUserEmrTemplate> BsUserEmrTemplates { get; set; }
        public DbSet<BsUserHouse> BsUserHouses { get; set; }
        public DbSet<BsUserImage> BsUserImages { get; set; }
        public DbSet<BsUserLocation> BsUserLocations { get; set; }
        public DbSet<BsUserMenu> BsUserMenus { get; set; }
        public DbSet<BsUserModule> BsUserModules { get; set; }
        public DbSet<BsUserPoint> BsUserPoints { get; set; }
        public DbSet<BsUserPointDtl> BsUserPointDtls { get; set; }
        public DbSet<BsUserRole> BsUserRoles { get; set; }
        public DbSet<BsUserRoom> BsUserRooms { get; set; }
        public DbSet<BsUserWindow> BsUserWindows { get; set; }
        public DbSet<BsUserWord> BsUserWords { get; set; }
        public DbSet<BsWorkType> BsWorkTypes { get; set; }
        public DbSet<BsXdGroup> BsXdGroups { get; set; }
        public DbSet<BsXdGroupDtl> BsXdGroupDtls { get; set; }
        public DbSet<BsXdRp> BsXdRps { get; set; }
        public DbSet<BsXdRpDtl> BsXdRpDtls { get; set; }
        public DbSet<BsYbCodeSpec> BsYbCodeSpecs { get; set; }
        public DbSet<BsYbIllType> BsYbIllTypes { get; set; }
        public DbSet<BsZyFeety> BsZyFeeties { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryLog> CategoryLogs { get; set; }
        public DbSet<cc1> cc1 { get; set; }
        public DbSet<CkBdBank> CkBdBanks { get; set; }
        public DbSet<CkBldApply> CkBldApplies { get; set; }
        public DbSet<CkBldDonate> CkBldDonates { get; set; }
        public DbSet<CkBldFree> CkBldFrees { get; set; }
        public DbSet<CkBldReaction> CkBldReactions { get; set; }
        public DbSet<CkBldReimb> CkBldReimbs { get; set; }
        public DbSet<CkBldToStation> CkBldToStations { get; set; }
        public DbSet<CkBloodBack> CkBloodBacks { get; set; }
        public DbSet<CkBloodSend> CkBloodSends { get; set; }
        public DbSet<CkBloodType> CkBloodTypes { get; set; }
        public DbSet<CkCompany> CkCompanies { get; set; }
        public DbSet<CkCompanyCkeck> CkCompanyCkecks { get; set; }
        public DbSet<CkCompanyGroup> CkCompanyGroups { get; set; }
        public DbSet<CkCompanyMan> CkCompanyMen { get; set; }
        public DbSet<CkCompGroupPsApply> CkCompGroupPsApplies { get; set; }
        public DbSet<CkFormula> CkFormulas { get; set; }
        public DbSet<CkGroup> CkGroups { get; set; }
        public DbSet<CKGROUPDEPARTMENT> CKGROUPDEPARTMENTs { get; set; }
        public DbSet<CkGroupItem> CkGroupItems { get; set; }
        public DbSet<CkIllAdvice> CkIllAdvices { get; set; }
        public DbSet<CkInFee> CkInFees { get; set; }
        public DbSet<CkItem> CkItems { get; set; }
        public DbSet<CkItemQc> CkItemQcs { get; set; }
        public DbSet<CkItemRange> CkItemRanges { get; set; }
        public DbSet<CkItemResult> CkItemResults { get; set; }
        public DbSet<CkLab> CkLabs { get; set; }
        public DbSet<CkLabDtl> CkLabDtls { get; set; }
        public DbSet<CkLabMic> CkLabMics { get; set; }
        public DbSet<CkLabMicDtl> CkLabMicDtls { get; set; }
        public DbSet<CkLabResult> CkLabResults { get; set; }
        public DbSet<CKMachine> CKMachines { get; set; }
        public DbSet<CKMachineFluid> CKMachineFluids { get; set; }
        public DbSet<CKMachineImage> CKMachineImages { get; set; }
        public DbSet<CKMachineNoPassage> CKMachineNoPassages { get; set; }
        public DbSet<CKMachinePassage> CKMachinePassages { get; set; }
        public DbSet<CKMachineResult> CKMachineResults { get; set; }
        public DbSet<CKMachineResult_A> CKMachineResult_A { get; set; }
        public DbSet<CKMachineResultDtl> CKMachineResultDtls { get; set; }
        public DbSet<CKMachineResultDtl_A> CKMachineResultDtl_A { get; set; }
        public DbSet<CKMachineSample> CKMachineSamples { get; set; }
        public DbSet<CkMain> CkMains { get; set; }
        public DbSet<CkMainIll> CkMainIlls { get; set; }
        public DbSet<CkProfile> CkProfiles { get; set; }
        public DbSet<CkPsApply> CkPsApplies { get; set; }
        public DbSet<CkQcControl> CkQcControls { get; set; }
        public DbSet<CkQcLot> CkQcLots { get; set; }
        public DbSet<CkQcResult> CkQcResults { get; set; }
        public DbSet<CkReport> CkReports { get; set; }
        public DbSet<CKReportDefine> CKReportDefines { get; set; }
        public DbSet<CkResult> CkResults { get; set; }
        public DbSet<CkResultGroup> CkResultGroups { get; set; }
        public DbSet<CkTestGroup> CkTestGroups { get; set; }
        public DbSet<CkTestType> CkTestTypes { get; set; }
        public DbSet<CkTogether> CkTogethers { get; set; }
        public DbSet<ConfirmPre> ConfirmPres { get; set; }
        public DbSet<CsAppDeptType> CsAppDeptTypes { get; set; }
        public DbSet<CsBigConsume> CsBigConsumes { get; set; }
        public DbSet<CsCostClass> CsCostClasses { get; set; }
        public DbSet<CsCostClassRela> CsCostClassRelas { get; set; }
        public DbSet<CsCostDetail> CsCostDetails { get; set; }
        public DbSet<CsCostSubj> CsCostSubjs { get; set; }
        public DbSet<CsDeptCost> CsDeptCosts { get; set; }
        public DbSet<CsDeptCostPara> CsDeptCostParas { get; set; }
        public DbSet<CsDeptCostTrace> CsDeptCostTraces { get; set; }
        public DbSet<CsDeptIncome> CsDeptIncomes { get; set; }
        public DbSet<CsIncomeDetail> CsIncomeDetails { get; set; }
        public DbSet<CsIncomeSubj> CsIncomeSubjs { get; set; }
        public DbSet<CsInWorkLog> CsInWorkLogs { get; set; }
        public DbSet<CsLocService> CsLocServices { get; set; }
        public DbSet<CsLogisticServe> CsLogisticServes { get; set; }
        public DbSet<CsLogisticServeDetail> CsLogisticServeDetails { get; set; }
        public DbSet<CsOuWorkLog> CsOuWorkLogs { get; set; }
        public DbSet<CsParaDeptsRec> CsParaDeptsRecs { get; set; }
        public DbSet<CsServerRelation> CsServerRelations { get; set; }
        public DbSet<CsStatu> CsStatus { get; set; }
        public DbSet<CsStLogisticServe> CsStLogisticServes { get; set; }
        public DbSet<DDLExecSql> DDLExecSqls { get; set; }
        public DbSet<DgDayGroup> DgDayGroups { get; set; }
        public DbSet<DgDrugTip> DgDrugTips { get; set; }
        public DbSet<DgIllCheckResult> DgIllCheckResults { get; set; }
        public DbSet<DgIllCompare> DgIllCompares { get; set; }
        public DbSet<DgIllCure> DgIllCures { get; set; }
        public DbSet<DgIllEmr> DgIllEmrs { get; set; }
        public DbSet<DgIllGroup> DgIllGroups { get; set; }
        public DbSet<DgIllSymptom> DgIllSymptoms { get; set; }
        public DbSet<DgIllXdRp> DgIllXdRps { get; set; }
        public DbSet<DgRoad> DgRoads { get; set; }
        public DbSet<DgRoadDtl> DgRoadDtls { get; set; }
        public DbSet<DgRoadIll> DgRoadIlls { get; set; }
        public DbSet<DgRoadLoc> DgRoadLocs { get; set; }
        public DbSet<DgRoadPat> DgRoadPats { get; set; }
        public DbSet<DgRoadPatDtl> DgRoadPatDtls { get; set; }
        public DbSet<DgTabu> DgTabus { get; set; }
        public DbSet<DhInAdviceLong> DhInAdviceLongs { get; set; }
        public DbSet<DhInAdviceTemp> DhInAdviceTemps { get; set; }
        public DbSet<DhInvoiceDtlTemp> DhInvoiceDtlTemps { get; set; }
        public DbSet<DhInvoiceTemp> DhInvoiceTemps { get; set; }
        public DbSet<DhOuRecipe> DhOuRecipes { get; set; }
        public DbSet<DhOuRecipeDtl> DhOuRecipeDtls { get; set; }
        public DbSet<DhStore> DhStores { get; set; }
        public DbSet<dtproperty> dtproperties { get; set; }
        public DbSet<ElBaseDtl> ElBaseDtls { get; set; }
        public DbSet<ElBaseFiled> ElBaseFileds { get; set; }
        public DbSet<ElDropDown> ElDropDowns { get; set; }
        public DbSet<ElEhr> ElEhrs { get; set; }
        public DbSet<ElForm> ElForms { get; set; }
        public DbSet<ElFormBsPat> ElFormBsPats { get; set; }
        public DbSet<ElFormDtl> ElFormDtls { get; set; }
        public DbSet<ElInoculate> ElInoculates { get; set; }
        public DbSet<ElPatForm> ElPatForms { get; set; }
        public DbSet<ElPatFormDrug> ElPatFormDrugs { get; set; }
        public DbSet<ElPatFormIll> ElPatFormIlls { get; set; }
        public DbSet<ElPatFormTest> ElPatFormTests { get; set; }
        public DbSet<ElPatFormTran> ElPatFormTrans { get; set; }
        public DbSet<ElPatFormValue> ElPatFormValues { get; set; }
        public DbSet<ElPatFormVDtl> ElPatFormVDtls { get; set; }
        public DbSet<ElPatRecord> ElPatRecords { get; set; }
        public DbSet<ElPrint> ElPrints { get; set; }
        public DbSet<ElTip> ElTips { get; set; }
        public DbSet<ElTipsPat> ElTipsPats { get; set; }
        public DbSet<EmrReCord> EmrReCords { get; set; }
        public DbSet<EqAttach> EqAttaches { get; set; }
        public DbSet<EqCheck> EqChecks { get; set; }
        public DbSet<EqRepair> EqRepairs { get; set; }
        public DbSet<EqTransfer> EqTransfers { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<FtDetail> FtDetails { get; set; }
        public DbSet<FtMain> FtMains { get; set; }
        public DbSet<GblAutoUpdate> GblAutoUpdates { get; set; }
        public DbSet<GblAutoUpdateOld> GblAutoUpdateOlds { get; set; }
        public DbSet<GblBaseTableItem> GblBaseTableItems { get; set; }
        public DbSet<GblCatalogExcept> GblCatalogExcepts { get; set; }
        public DbSet<GblCatalogJoin> GblCatalogJoins { get; set; }
        public DbSet<GblCatalogKey> GblCatalogKeys { get; set; }
        public DbSet<GblChinChar> GblChinChars { get; set; }
        public DbSet<GblCurrentUser> GblCurrentUsers { get; set; }
        public DbSet<GblElClass> GblElClasses { get; set; }
        public DbSet<GblElGroup> GblElGroups { get; set; }
        public DbSet<GblEmail> GblEmails { get; set; }
        public DbSet<GblEmailUser> GblEmailUsers { get; set; }
        public DbSet<GblEMRBranch> GblEMRBranches { get; set; }
        public DbSet<GblEMRCatalog> GblEMRCatalogs { get; set; }
        public DbSet<GblEMRFile> GblEMRFiles { get; set; }
        public DbSet<GblEMRQcGroup> GblEMRQcGroups { get; set; }
        public DbSet<GblEMRQcItem> GblEMRQcItems { get; set; }
        public DbSet<GblFieldDesc> GblFieldDescs { get; set; }
        public DbSet<GblFormEdit> GblFormEdits { get; set; }
        public DbSet<GblFuction> GblFuctions { get; set; }
        public DbSet<GblFunDemo> GblFunDemoes { get; set; }
        public DbSet<GblFunTrace> GblFunTraces { get; set; }
        public DbSet<GblGetSequenceNum> GblGetSequenceNums { get; set; }
        public DbSet<GblInvReg> GblInvRegs { get; set; }
        public DbSet<GBLITEMGROUP> GBLITEMGROUPs { get; set; }
        public DbSet<GBLITEMGROUPDTL> GBLITEMGROUPDTLs { get; set; }
        public DbSet<GblKeyLockSetting> GblKeyLockSettings { get; set; }
        public DbSet<GblLastId> GblLastIds { get; set; }
        public DbSet<GblLatDayRunTime> GblLatDayRunTimes { get; set; }
        public DbSet<GblModiHost> GblModiHosts { get; set; }
        public DbSet<GblModule> GblModules { get; set; }
        public DbSet<GblMrk> GblMrks { get; set; }
        public DbSet<GblOnliner> GblOnliners { get; set; }
        public DbSet<GblPatientMenu> GblPatientMenus { get; set; }
        public DbSet<GblPhoneMsg> GblPhoneMsgs { get; set; }
        public DbSet<GblPrinter> GblPrinters { get; set; }
        public DbSet<GblQuestion> GblQuestions { get; set; }
        public DbSet<GblReport> GblReports { get; set; }
        public DbSet<GblReportDetail> GblReportDetails { get; set; }
        public DbSet<GblReportGroup> GblReportGroups { get; set; }
        public DbSet<GblRole> GblRoles { get; set; }
        public DbSet<GblRoleModule> GblRoleModules { get; set; }
        public DbSet<GblSetting> GblSettings { get; set; }
        public DbSet<GblSystem> GblSystems { get; set; }
        public DbSet<GblSystemFunction> GblSystemFunctions { get; set; }
        public DbSet<GblSystemMenu> GblSystemMenus { get; set; }
        public DbSet<GblTrace> GblTraces { get; set; }
        public DbSet<HuAdjust> HuAdjusts { get; set; }
        public DbSet<HuAdjustDtl> HuAdjustDtls { get; set; }
        public DbSet<HuAdjustPlan> HuAdjustPlans { get; set; }
        public DbSet<HuAdjustPlanDtl> HuAdjustPlanDtls { get; set; }
        public DbSet<HuBack> HuBacks { get; set; }
        public DbSet<HuBackDtl> HuBackDtls { get; set; }
        public DbSet<HuCheck> HuChecks { get; set; }
        public DbSet<HuCheckDtl> HuCheckDtls { get; set; }
        public DbSet<HuCheckDtl_bak0531> HuCheckDtl_bak0531 { get; set; }
        public DbSet<HuCheckSum> HuCheckSums { get; set; }
        public DbSet<HuLose> HuLoses { get; set; }
        public DbSet<HuLoseDtl> HuLoseDtls { get; set; }
        public DbSet<HuOtherIn> HuOtherIns { get; set; }
        public DbSet<HuOtherInDtl> HuOtherInDtls { get; set; }
        public DbSet<HuOtherOut> HuOtherOuts { get; set; }
        public DbSet<HuOtherOutDtl> HuOtherOutDtls { get; set; }
        public DbSet<HuOut> HuOuts { get; set; }
        public DbSet<HuOutDtl> HuOutDtls { get; set; }
        public DbSet<HuPk> HuPks { get; set; }
        public DbSet<HuPkDtl> HuPkDtls { get; set; }
        public DbSet<HuPy> HuPies { get; set; }
        public DbSet<HuPydtl> HuPydtls { get; set; }
        public DbSet<HuSplit> HuSplits { get; set; }
        public DbSet<HuSplitIn> HuSplitIns { get; set; }
        public DbSet<HuSplitOut> HuSplitOuts { get; set; }
        public DbSet<HuStock> HuStocks { get; set; }
        public DbSet<HuStockDtl> HuStockDtls { get; set; }
        public DbSet<HuStockReq> HuStockReqs { get; set; }
        public DbSet<HuStockReqdtl> HuStockReqdtls { get; set; }
        public DbSet<HuStoreLog> HuStoreLogs { get; set; }
        public DbSet<HuStore> HuStores { get; set; }
        public DbSet<HustoresDay> HustoresDays { get; set; }
        public DbSet<HuVoucher> HuVouchers { get; set; }
        public DbSet<HuVoucherDtl> HuVoucherDtls { get; set; }
        public DbSet<InAdviceGroup> InAdviceGroups { get; set; }
        public DbSet<InAdviceLong> InAdviceLongs { get; set; }
        public DbSet<InAdviceLong_A> InAdviceLong_A { get; set; }
        public DbSet<INADVICENURSE> INADVICENURSEs { get; set; }
        public DbSet<InAdviceTemp> InAdviceTemps { get; set; }
        public DbSet<InAdviceTemp_A> InAdviceTemp_A { get; set; }
        public DbSet<InAdviceWeekDay> InAdviceWeekDays { get; set; }
        public DbSet<InArrearAmount> InArrearAmounts { get; set; }
        public DbSet<INBABYBODYHEAT> INBABYBODYHEATs { get; set; }
        public DbSet<InBodyHeat> InBodyHeats { get; set; }
        public DbSet<InCallBack> InCallBacks { get; set; }
        public DbSet<InChangeBed> InChangeBeds { get; set; }
        public DbSet<InChinRicipe> InChinRicipes { get; set; }
        public DbSet<InChinRicipeDtl> InChinRicipeDtls { get; set; }
        public DbSet<InChinRicipExec> InChinRicipExecs { get; set; }
        public DbSet<InDayAdd> InDayAdds { get; set; }
        public DbSet<InDayCharge> InDayCharges { get; set; }
        public DbSet<InDaySum> InDaySums { get; set; }
        public DbSet<InDeposit> InDeposits { get; set; }
        public DbSet<InDrugReq> InDrugReqs { get; set; }
        public DbSet<InDrugReqBack> InDrugReqBacks { get; set; }
        public DbSet<InDrugReqdtl> InDrugReqdtls { get; set; }
        public DbSet<InDrugReqdtl_A> InDrugReqdtl_A { get; set; }
        public DbSet<InDrugReqdtlSkinBack> InDrugReqdtlSkinBacks { get; set; }
        public DbSet<InEMR> InEMRs { get; set; }
        public DbSet<InEmrChange> InEmrChanges { get; set; }
        public DbSet<InEmrRtf> InEmrRtfs { get; set; }
        public DbSet<InEmrScore> InEmrScores { get; set; }
        public DbSet<InEmrSign> InEmrSigns { get; set; }
        public DbSet<InEmrXml> InEmrXmls { get; set; }
        public DbSet<InExecute> InExecutes { get; set; }
        public DbSet<InExecute_A> InExecute_A { get; set; }
        public DbSet<InFeeCheck> InFeeChecks { get; set; }
        public DbSet<InGfReport> InGfReports { get; set; }
        public DbSet<InHosBed> InHosBeds { get; set; }
        public DbSet<InHosInfo> InHosInfoes { get; set; }
        public DbSet<InHosMzIll> InHosMzIlls { get; set; }
        public DbSet<InHosOp> InHosOps { get; set; }
        public DbSet<InHosUsageItem> InHosUsageItems { get; set; }
        public DbSet<InInvoice> InInvoices { get; set; }
        public DbSet<InInvoiceDtl> InInvoiceDtls { get; set; }
        public DbSet<InInvoiceDtl_A> InInvoiceDtl_A { get; set; }
        public DbSet<InInvoiceDtlBed> InInvoiceDtlBeds { get; set; }
        public DbSet<InInvoiceDtlCancel> InInvoiceDtlCancels { get; set; }
        public DbSet<InInvoiceDtlChk> InInvoiceDtlChks { get; set; }
        public DbSet<InInvoiceDtlDump> InInvoiceDtlDumps { get; set; }
        public DbSet<InInvoiceDtlTemp> InInvoiceDtlTemps { get; set; }
        public DbSet<InInvoiceFeetySum> InInvoiceFeetySums { get; set; }
        public DbSet<InInvoiceInvItemSum> InInvoiceInvItemSums { get; set; }
        public DbSet<InInvoYB> InInvoYBs { get; set; }
        public DbSet<InLocNoPay> InLocNoPays { get; set; }
        public DbSet<InLogInHospital> InLogInHospitals { get; set; }
        public DbSet<InLogOutHospital> InLogOutHospitals { get; set; }
        public DbSet<InLogOutLocation> InLogOutLocations { get; set; }
        public DbSet<InLogStatusIn> InLogStatusIns { get; set; }
        public DbSet<InNotAttach> InNotAttaches { get; set; }
        public DbSet<InOpsSum> InOpsSums { get; set; }
        public DbSet<InOutLocation> InOutLocations { get; set; }
        public DbSet<InPatFeesList> InPatFeesLists { get; set; }
        public DbSet<INPATFEESLIST_J> INPATFEESLIST_J { get; set; }
        public DbSet<InPatLog> InPatLogs { get; set; }
        public DbSet<InPay> InPays { get; set; }
        public DbSet<InRecFirstPage> InRecFirstPages { get; set; }
        public DbSet<InRmKsDtl> InRmKsDtls { get; set; }
        public DbSet<InWorkLog> InWorkLogs { get; set; }
        public DbSet<InYBBalance> InYBBalances { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<main_aa> main_aa { get; set; }
        public DbSet<NfInfect> NfInfects { get; set; }
        public DbSet<NfInfectDrug> NfInfectDrugs { get; set; }
        public DbSet<NfInfectIll> NfInfectIlls { get; set; }
        public DbSet<NfInfectReason> NfInfectReasons { get; set; }
        public DbSet<NfInfectTest> NfInfectTests { get; set; }
        public DbSet<NfInfectTestBacteria> NfInfectTestBacterias { get; set; }
        public DbSet<NrPlan> NrPlans { get; set; }
        public DbSet<NrPregnancy> NrPregnancies { get; set; }
        public DbSet<NrPregnancyDtl> NrPregnancyDtls { get; set; }
        public DbSet<NrRecord> NrRecords { get; set; }
        public DbSet<OaDocAuth> OaDocAuths { get; set; }
        public DbSet<OaDocFile> OaDocFiles { get; set; }
        public DbSet<OaDocKey> OaDocKeys { get; set; }
        public DbSet<OaDocReader> OaDocReaders { get; set; }
        public DbSet<OaDocument> OaDocuments { get; set; }
        public DbSet<OaSchedule> OaSchedules { get; set; }
        public DbSet<OpsApply> OpsApplies { get; set; }
        public DbSet<OpsCharge> OpsCharges { get; set; }
        public DbSet<OpsEvent> OpsEvents { get; set; }
        public DbSet<OpsMan> OpsMen { get; set; }
        public DbSet<OpsNurse> OpsNurses { get; set; }
        public DbSet<OpsPostTreat> OpsPostTreats { get; set; }
        public DbSet<OtBid> OtBids { get; set; }
        public DbSet<OtBidDtl> OtBidDtls { get; set; }
        public DbSet<OuClincDiag> OuClincDiags { get; set; }
        public DbSet<OuClinicFirst> OuClinicFirsts { get; set; }
        public DbSet<OuDayReport> OuDayReports { get; set; }
        public DbSet<OuDiagCall> OuDiagCalls { get; set; }
        public DbSet<OuDocRegType> OuDocRegTypes { get; set; }
        public DbSet<OuDocSpanSub> OuDocSpanSubs { get; set; }
        public DbSet<OuExecute> OuExecutes { get; set; }
        public DbSet<OuExecuteBack> OuExecuteBacks { get; set; }
        public DbSet<OuExecuteDtl> OuExecuteDtls { get; set; }
        public DbSet<OuExecuteDtl_A> OuExecuteDtl_A { get; set; }
        public DbSet<OuGfbxReport> OuGfbxReports { get; set; }
        public DbSet<OuGFReport> OuGFReports { get; set; }
        public DbSet<OuHosInfo> OuHosInfoes { get; set; }
        public DbSet<OuIllReport> OuIllReports { get; set; }
        public DbSet<OuInCar> OuInCars { get; set; }
        public DbSet<OuInvoice> OuInvoices { get; set; }
        public DbSet<OuInvoiceDtl> OuInvoiceDtls { get; set; }
        public DbSet<OuInvoiceDtl_A> OuInvoiceDtl_A { get; set; }
        public DbSet<OuInvoiceFeetySum> OuInvoiceFeetySums { get; set; }
        public DbSet<OuInvoiceInvItemSum> OuInvoiceInvItemSums { get; set; }
        public DbSet<OuInvoicePay> OuInvoicePays { get; set; }
        public DbSet<ouinvoyb> ouinvoybs { get; set; }
        public DbSet<OuLeadReg> OuLeadRegs { get; set; }
        public DbSet<OulInvoiceReg> OulInvoiceRegs { get; set; }
        public DbSet<OuNotAttach> OuNotAttaches { get; set; }
        public DbSet<OuRecipe> OuRecipes { get; set; }
        public DbSet<OuRecipeBack> OuRecipeBacks { get; set; }
        public DbSet<OuRecipeChin> OuRecipeChins { get; set; }
        public DbSet<OuRecipeDtl> OuRecipeDtls { get; set; }
        public DbSet<OuRecipeDtl_A> OuRecipeDtl_A { get; set; }
        public DbSet<OuRecipeTemp> OuRecipeTemps { get; set; }
        public DbSet<out_t_jczxxx> out_t_jczxxx { get; set; }
        public DbSet<OutMedTableHi> OutMedTableHis { get; set; }
        public DbSet<OuTransferHosp> OuTransferHosps { get; set; }
        public DbSet<PatCardFee> PatCardFees { get; set; }
        public DbSet<PlItem> PlItems { get; set; }
        public DbSet<PlProject> PlProjects { get; set; }
        public DbSet<PlProjectItem> PlProjectItems { get; set; }
        public DbSet<PsApplyReport> PsApplyReports { get; set; }
        public DbSet<PsDiagDoctor> PsDiagDoctors { get; set; }
        public DbSet<PsDiagMeeting> PsDiagMeetings { get; set; }
        public DbSet<PsDrugAction> PsDrugActions { get; set; }
        public DbSet<PsExecute> PsExecutes { get; set; }
        public DbSet<RdBrainDead> RdBrainDeads { get; set; }
        public DbSet<RdCancer> RdCancers { get; set; }
        public DbSet<RdChangeOut> RdChangeOuts { get; set; }
        public DbSet<RdContract> RdContracts { get; set; }
        public DbSet<RdCurePlan> RdCurePlans { get; set; }
        public DbSet<RdFollow> RdFollows { get; set; }
        public DbSet<RdHurt> RdHurts { get; set; }
        public DbSet<RdInfectiou> RdInfectious { get; set; }
        public DbSet<RdInfectStd> RdInfectStds { get; set; }
        public DbSet<RdLesson> RdLessons { get; set; }
        public DbSet<RdLessonMan> RdLessonMen { get; set; }
        public DbSet<RdLiver> RdLivers { get; set; }
        public DbSet<RdNewBirth> RdNewBirths { get; set; }
        public DbSet<Report_Table> Report_Table { get; set; }
        public DbSet<RmAdjust> RmAdjusts { get; set; }
        public DbSet<RmAdjustDtl> RmAdjustDtls { get; set; }
        public DbSet<RmAppDrug> RmAppDrugs { get; set; }
        public DbSet<RmAppDrugDtl> RmAppDrugDtls { get; set; }
        public DbSet<RmApplback> RmApplbacks { get; set; }
        public DbSet<RmApplbackDtl> RmApplbackDtls { get; set; }
        public DbSet<RmBack> RmBacks { get; set; }
        public DbSet<RmBackDetail> RmBackDetails { get; set; }
        public DbSet<RmCheck> RmChecks { get; set; }
        public DbSet<RmCheckDtl> RmCheckDtls { get; set; }
        public DbSet<RmCheckGroupDtl> RmCheckGroupDtls { get; set; }
        public DbSet<RmCheckSum> RmCheckSums { get; set; }
        public DbSet<RmGroupPrintNum> RmGroupPrintNums { get; set; }
        public DbSet<RmKOutDtl> RmKOutDtls { get; set; }
        public DbSet<RmKsBack> RmKsBacks { get; set; }
        public DbSet<RmKsBackDtl> RmKsBackDtls { get; set; }
        public DbSet<RmKsOut> RmKsOuts { get; set; }
        public DbSet<RmLose> RmLoses { get; set; }
        public DbSet<RmLoseDtl> RmLoseDtls { get; set; }
        public DbSet<RmMove> RmMoves { get; set; }
        public DbSet<RmMoveDtl> RmMoveDtls { get; set; }
        public DbSet<RmOtherIn> RmOtherIns { get; set; }
        public DbSet<RmOtherInDtl> RmOtherInDtls { get; set; }
        public DbSet<RmOut> RmOuts { get; set; }
        public DbSet<RmOutDtl> RmOutDtls { get; set; }
        public DbSet<RmOutOth> RmOutOths { get; set; }
        public DbSet<RmOutOthDtl> RmOutOthDtls { get; set; }
        public DbSet<RmPk> RmPks { get; set; }
        public DbSet<RmPkDtl> RmPkDtls { get; set; }
        public DbSet<RmPy> RmPies { get; set; }
        public DbSet<RmPyDtl> RmPyDtls { get; set; }
        public DbSet<RmSending> RmSendings { get; set; }
        public DbSet<RmSplit> RmSplits { get; set; }
        public DbSet<RmSplitIn> RmSplitIns { get; set; }
        public DbSet<RmSplitOut> RmSplitOuts { get; set; }
        public DbSet<RmStoreLog> RmStoreLogs { get; set; }
        public DbSet<Rmstore> Rmstores { get; set; }
        public DbSet<rmstores_bak0531> rmstores_bak0531 { get; set; }
        public DbSet<RmstoresDay> RmstoresDays { get; set; }
        public DbSet<RmstoreStockNum> RmstoreStockNums { get; set; }
        public DbSet<RmstoreStockNum2> RmstoreStockNum2 { get; set; }
        public DbSet<RmUnderLine> RmUnderLines { get; set; }
        public DbSet<RmZyBack> RmZyBacks { get; set; }
        public DbSet<RmZyBackDtl> RmZyBackDtls { get; set; }
        public DbSet<RmZyOut> RmZyOuts { get; set; }
        public DbSet<RmZyOutDtl> RmZyOutDtls { get; set; }
        public DbSet<RTRJKREPORT> RTRJKREPORTs { get; set; }
        public DbSet<TmpEmr> TmpEmrs { get; set; }
        public DbSet<TmpItem> TmpItems { get; set; }
        public DbSet<TmpMyPat> TmpMyPats { get; set; }
        public DbSet<TmpOuEmr> TmpOuEmrs { get; set; }
        public DbSet<TmpWordDetail> TmpWordDetails { get; set; }
        public DbSet<Trace> Traces { get; set; }
        public DbSet<TrAdvice> TrAdvices { get; set; }
        public DbSet<TrDoctorEmr> TrDoctorEmrs { get; set; }
        public DbSet<TrInHosInfo> TrInHosInfoes { get; set; }
        public DbSet<TrLocDayRatio> TrLocDayRatios { get; set; }
        public DbSet<TrPractise> TrPractises { get; set; }
        public DbSet<TrScheduler> TrSchedulers { get; set; }
        public DbSet<TrScheLine> TrScheLines { get; set; }
        public DbSet<YBChargeLog> YBChargeLogs { get; set; }
        public DbSet<YbPatSeq> YbPatSeqs { get; set; }
        public DbSet<YbQuery> YbQueries { get; set; }
        public DbSet<ZXYBMXDTL> ZXYBMXDTLs { get; set; }
        public DbSet<ZXYbPat> ZXYbPats { get; set; }
        public DbSet<His_eng_cf> His_eng_cf { get; set; }
        public DbSet<His_eng_cf_item> His_eng_cf_item { get; set; }
        public DbSet<his_eng_order> his_eng_order { get; set; }
        public DbSet<his_eng_order_diagnose> his_eng_order_diagnose { get; set; }
        public DbSet<his_eng_order_drug> his_eng_order_drug { get; set; }
        public DbSet<his_eng_order_exam> his_eng_order_exam { get; set; }
        public DbSet<his_eng_order_operation> his_eng_order_operation { get; set; }
        public DbSet<mdc_drug_match_info_view> mdc_drug_match_info_view { get; set; }
        public DbSet<mdc_route_match_info_view> mdc_route_match_info_view { get; set; }
        public DbSet<out_v_jc> out_v_jc { get; set; }
        public DbSet<OUT_V_JY> OUT_V_JY { get; set; }
        public DbSet<OUT_V_JY_ZB> OUT_V_JY_ZB { get; set; }
        public DbSet<OUT_V_PACS> OUT_V_PACS { get; set; }
        public DbSet<OUT_V_PACS_ZB> OUT_V_PACS_ZB { get; set; }
        public DbSet<syssegment> syssegments { get; set; }
        public DbSet<TB_CIS_Outpatient_Prescription> TB_CIS_Outpatient_Prescription { get; set; }
        public DbSet<TB_CIS_Outpatient_Registration> TB_CIS_Outpatient_Registration { get; set; }
        public DbSet<TB_CIS_Outpatient_Visiting_Record> TB_CIS_Outpatient_Visiting_Record { get; set; }
        public DbSet<TB_CIS_OutpatientDrAdvice_Detail> TB_CIS_OutpatientDrAdvice_Detail { get; set; }
        public DbSet<TB_HIS_Fee_Detail> TB_HIS_Fee_Detail { get; set; }
        public DbSet<TB_HIS_Fee_Record> TB_HIS_Fee_Record { get; set; }
        public DbSet<TB_Patient_Information> TB_Patient_Information { get; set; }
        public DbSet<View_RdInfectious> View_RdInfectious { get; set; }
        public DbSet<VIEW1> VIEW1 { get; set; }
        public DbSet<VIEW2> VIEW2 { get; set; }
        public DbSet<viewTestResultCumulate> viewTestResultCumulates { get; set; }
        public DbSet<Vw_Bingrzl> Vw_Bingrzl { get; set; }
        public DbSet<Vw_ChinRecipe_Detail_Print> Vw_ChinRecipe_Detail_Print { get; set; }
        public DbSet<Vw_ChinRecipe_Detail_PrintA> Vw_ChinRecipe_Detail_PrintA { get; set; }
        public DbSet<Vw_ChinRecipe_Detail_PrintB> Vw_ChinRecipe_Detail_PrintB { get; set; }
        public DbSet<Vw_CKMachineResult_A> Vw_CKMachineResult_A { get; set; }
        public DbSet<Vw_CKMachineResult_B> Vw_CKMachineResult_B { get; set; }
        public DbSet<Vw_CKMachineResultDtl_A> Vw_CKMachineResultDtl_A { get; set; }
        public DbSet<Vw_CKMachineResultDtl_B> Vw_CKMachineResultDtl_B { get; set; }
        public DbSet<VW_CkProfile> VW_CkProfile { get; set; }
        public DbSet<vw_DI_CkLab> vw_DI_CkLab { get; set; }
        public DbSet<Vw_DI_CkLabResult> Vw_DI_CkLabResult { get; set; }
        public DbSet<Vw_DI_ClincDiag> Vw_DI_ClincDiag { get; set; }
        public DbSet<Vw_DI_EMR_HaveTo> Vw_DI_EMR_HaveTo { get; set; }
        public DbSet<Vw_DI_InAdvice> Vw_DI_InAdvice { get; set; }
        public DbSet<Vw_DI_OuHosInfo> Vw_DI_OuHosInfo { get; set; }
        public DbSet<Vw_DI_OuInvoiceSum> Vw_DI_OuInvoiceSum { get; set; }
        public DbSet<Vw_DI_OurecipeDtl> Vw_DI_OurecipeDtl { get; set; }
        public DbSet<Vw_DoctorInSum> Vw_DoctorInSum { get; set; }
        public DbSet<Vw_DoctorOuSum> Vw_DoctorOuSum { get; set; }
        public DbSet<Vw_FlightChecking> Vw_FlightChecking { get; set; }
        public DbSet<Vw_FlightExamine> Vw_FlightExamine { get; set; }
        public DbSet<Vw_FlightExamineResult> Vw_FlightExamineResult { get; set; }
        public DbSet<Vw_FlightInDepartment> Vw_FlightInDepartment { get; set; }
        public DbSet<Vw_FlightInHosInfo> Vw_FlightInHosInfo { get; set; }
        public DbSet<Vw_FlightPatient> Vw_FlightPatient { get; set; }
        public DbSet<Vw_FlightReceipe> Vw_FlightReceipe { get; set; }
        public DbSet<Vw_FlightSurgeryLayout> Vw_FlightSurgeryLayout { get; set; }
        public DbSet<Vw_FlightSurgeryNotice> Vw_FlightSurgeryNotice { get; set; }
        public DbSet<Vw_FlightUser> Vw_FlightUser { get; set; }
        public DbSet<VW_HisInPatient> VW_HisInPatient { get; set; }
        public DbSet<VW_HisOutPatient> VW_HisOutPatient { get; set; }
        public DbSet<Vw_InAdviceLong_A> Vw_InAdviceLong_A { get; set; }
        public DbSet<Vw_InAdviceLong_B> Vw_InAdviceLong_B { get; set; }
        public DbSet<Vw_InAdviceTemp_A> Vw_InAdviceTemp_A { get; set; }
        public DbSet<Vw_InAdviceTemp_B> Vw_InAdviceTemp_B { get; set; }
        public DbSet<VW_InChinRicipeSend> VW_InChinRicipeSend { get; set; }
        public DbSet<Vw_InDaySum> Vw_InDaySum { get; set; }
        public DbSet<Vw_InDrugReqdtl_A> Vw_InDrugReqdtl_A { get; set; }
        public DbSet<Vw_InDrugReqdtl_B> Vw_InDrugReqdtl_B { get; set; }
        public DbSet<Vw_InExecute_A> Vw_InExecute_A { get; set; }
        public DbSet<Vw_InExecute_B> Vw_InExecute_B { get; set; }
        public DbSet<vw_inhosinfoxx> vw_inhosinfoxx { get; set; }
        public DbSet<Vw_InInvoiceDtl_A> Vw_InInvoiceDtl_A { get; set; }
        public DbSet<Vw_InInvoiceDtl_B> Vw_InInvoiceDtl_B { get; set; }
        public DbSet<Vw_InOperDayInvoice> Vw_InOperDayInvoice { get; set; }
        public DbSet<Vw_InWorkLog> Vw_InWorkLog { get; set; }
        public DbSet<Vw_InWorkLog_hz> Vw_InWorkLog_hz { get; set; }
        public DbSet<Vw_ItemTrace> Vw_ItemTrace { get; set; }
        public DbSet<Vw_mmzy_mzfp> Vw_mmzy_mzfp { get; set; }
        public DbSet<Vw_mmzy_mzgh> Vw_mmzy_mzgh { get; set; }
        public DbSet<Vw_mmzy_mztf> Vw_mmzy_mztf { get; set; }
        public DbSet<Vw_mmzy_mzzlrc_fy> Vw_mmzy_mzzlrc_fy { get; set; }
        public DbSet<Vw_Mzgnkssr> Vw_Mzgnkssr { get; set; }
        public DbSet<Vw_mzkssftj> Vw_mzkssftj { get; set; }
        public DbSet<Vw_MzLocationFeePayed> Vw_MzLocationFeePayed { get; set; }
        public DbSet<Vw_OuExecuteDtl_A> Vw_OuExecuteDtl_A { get; set; }
        public DbSet<Vw_OuExecuteDtl_B> Vw_OuExecuteDtl_B { get; set; }
        public DbSet<Vw_OuInvoiceDtl_A> Vw_OuInvoiceDtl_A { get; set; }
        public DbSet<Vw_OuInvoiceDtl_B> Vw_OuInvoiceDtl_B { get; set; }
        public DbSet<Vw_OuOperDayInvoice> Vw_OuOperDayInvoice { get; set; }
        public DbSet<Vw_OuRecipeDtl_A> Vw_OuRecipeDtl_A { get; set; }
        public DbSet<Vw_OuRecipeDtl_B> Vw_OuRecipeDtl_B { get; set; }
        public DbSet<Vw_PatientInNTime> Vw_PatientInNTime { get; set; }
        public DbSet<Vw_Recipe_Detail_Print> Vw_Recipe_Detail_Print { get; set; }
        public DbSet<Vw_Recipe_Detail_Print1> Vw_Recipe_Detail_Print1 { get; set; }
        public DbSet<Vw_Recipe_Xdrp_Print> Vw_Recipe_Xdrp_Print { get; set; }
        public DbSet<VW_RKBillInfo> VW_RKBillInfo { get; set; }
        public DbSet<Vw_sssf> Vw_sssf { get; set; }
        public DbSet<Vw_sstj> Vw_sstj { get; set; }
        public DbSet<Vw_TraceLog> Vw_TraceLog { get; set; }
        public DbSet<Vw_xxk_ryrsbcs> Vw_xxk_ryrsbcs { get; set; }
        public DbSet<Vw_yfmzgzl> Vw_yfmzgzl { get; set; }
        public DbSet<Vw_yfzygzl_zcy> Vw_yfzygzl_zcy { get; set; }
        public DbSet<Vw_yingxjc_MZ> Vw_yingxjc_MZ { get; set; }
        public DbSet<Vw_yingxjc_ZY> Vw_yingxjc_ZY { get; set; }
        public DbSet<Vw_yptj> Vw_yptj { get; set; }
        public DbSet<Vw_ypxx> Vw_ypxx { get; set; }
        public DbSet<Vw_yszl> Vw_yszl { get; set; }
        public DbSet<Vw_zy_ybbrfy> Vw_zy_ybbrfy { get; set; }
        public DbSet<Vw_zyanj> Vw_zyanj { get; set; }
        public DbSet<Vw_zybrxmhz> Vw_zybrxmhz { get; set; }
        public DbSet<Vw_zybryecx> Vw_zybryecx { get; set; }
        public DbSet<Vw_zybryskmxb> Vw_zybryskmxb { get; set; }
        public DbSet<Vw_zycybrjk> Vw_zycybrjk { get; set; }
        public DbSet<Vw_zycybrxx> Vw_zycybrxx { get; set; }
        public DbSet<Vw_zyFree> Vw_zyFree { get; set; }
        public DbSet<Vw_zygnkssr> Vw_zygnkssr { get; set; }
        public DbSet<Vw_Zykssftj> Vw_Zykssftj { get; set; }
        public DbSet<Vw_ZyLocationFee> Vw_ZyLocationFee { get; set; }
        public DbSet<Vw_ZyLocationFeePayed> Vw_ZyLocationFeePayed { get; set; }
        public DbSet<Vw_zyrydjxx> Vw_zyrydjxx { get; set; }
        public DbSet<Vw_zyrydjxx_brly> Vw_zyrydjxx_brly { get; set; }
        public DbSet<Vw_zyrydjxx_cz> Vw_zyrydjxx_cz { get; set; }
        public DbSet<Vw_zyrydjxx_ddybsyl> Vw_zyrydjxx_ddybsyl { get; set; }
        public DbSet<Vw_zyrydjxx_mnnh> Vw_zyrydjxx_mnnh { get; set; }
        public DbSet<Vw_zyrydjxx_syyb> Vw_zyrydjxx_syyb { get; set; }
        public DbSet<Vw_zyrydjxx_yb> Vw_zyrydjxx_yb { get; set; }
        public DbSet<Vw_zysfczjcx> Vw_zysfczjcx { get; set; }
        public DbSet<Vw_zysfflhz> Vw_zysfflhz { get; set; }
        public DbSet<Vw_zysfxmhb> Vw_zysfxmhb { get; set; }
        public DbSet<Vw_zysfxmhb_ks> Vw_zysfxmhb_ks { get; set; }
        public DbSet<Vw_zysfxmmx> Vw_zysfxmmx { get; set; }
        public DbSet<Vw_zysfxmmx_yb> Vw_zysfxmmx_yb { get; set; }
        public DbSet<Vw_zyzybrxx> Vw_zyzybrxx { get; set; }
        public DbSet<VwBed> VwBeds { get; set; }
        public DbSet<VwBedList> VwBedLists { get; set; }
        public DbSet<VwBedSearch> VwBedSearches { get; set; }
        public DbSet<vwBsItem> vwBsItems { get; set; }
        public DbSet<VwBsItemMini> VwBsItemMinis { get; set; }
        public DbSet<VwBsPatient> VwBsPatients { get; set; }
        public DbSet<VwBsPatientForInHospital> VwBsPatientForInHospitals { get; set; }
        public DbSet<VwBsPatMenuIndex> VwBsPatMenuIndexes { get; set; }
        public DbSet<VwBsPatType> VwBsPatTypes { get; set; }
        public DbSet<VwBsXdRp> VwBsXdRps { get; set; }
        public DbSet<VwCkLab> VwCkLabs { get; set; }
        public DbSet<VwCkLabResult> VwCkLabResults { get; set; }
        public DbSet<VwCkMachineSample> VwCkMachineSamples { get; set; }
        public DbSet<VwCkMachineTest> VwCkMachineTests { get; set; }
        public DbSet<VwCkPatientResult> VwCkPatientResults { get; set; }
        public DbSet<VwCkQcResult> VwCkQcResults { get; set; }
        public DbSet<VwCkResult> VwCkResults { get; set; }
        public DbSet<VwCommitteeFamily> VwCommitteeFamilies { get; set; }
        public DbSet<VwEquipment> VwEquipments { get; set; }
        public DbSet<VwEquipmentRepair> VwEquipmentRepairs { get; set; }
        public DbSet<VwGblEMRCatalog> VwGblEMRCatalogs { get; set; }
        public DbSet<VwGnKsFee> VwGnKsFees { get; set; }
        public DbSet<VwHuInAndOutInfo> VwHuInAndOutInfoes { get; set; }
        public DbSet<VwHuInAndOutInfo_Wz> VwHuInAndOutInfo_Wz { get; set; }
        public DbSet<VwHuOutBack> VwHuOutBacks { get; set; }
        public DbSet<VwHuStoreLog> VwHuStoreLogs { get; set; }
        public DbSet<VwHuStoreLog_temp> VwHuStoreLog_temp { get; set; }
        public DbSet<VwHuStoreLog_Wz> VwHuStoreLog_Wz { get; set; }
        public DbSet<VWHuStore> VWHuStores { get; set; }
        public DbSet<vwHustoresDay> vwHustoresDays { get; set; }
        public DbSet<VWHuStoresFK> VWHuStoresFKs { get; set; }
        public DbSet<VwHuStoresHasNum> VwHuStoresHasNums { get; set; }
        public DbSet<VwHustoresRemain> VwHustoresRemains { get; set; }
        public DbSet<VwInAndOuInvoice> VwInAndOuInvoices { get; set; }
        public DbSet<VwInAntibiotic> VwInAntibiotics { get; set; }
        public DbSet<VwInChinFee> VwInChinFees { get; set; }
        public DbSet<VwInDeposit> VwInDeposits { get; set; }
        public DbSet<VwInDepositPay> VwInDepositPays { get; set; }
        public DbSet<VwInDoctorAdvice> VwInDoctorAdvices { get; set; }
        public DbSet<VwInDoctorAdviceLongTemp> VwInDoctorAdviceLongTemps { get; set; }
        public DbSet<VwInDrugCheck> VwInDrugChecks { get; set; }
        public DbSet<VwInDrugIssueSend> VwInDrugIssueSends { get; set; }
        public DbSet<VwInDrugIssueSendLongAlone> VwInDrugIssueSendLongAlones { get; set; }
        public DbSet<VwInExecute> VwInExecutes { get; set; }
        public DbSet<VwInExecuteLate> VwInExecuteLates { get; set; }
        public DbSet<VwInHosInfo> VwInHosInfoes { get; set; }
        public DbSet<VwInHosInfoNormal> VwInHosInfoNormals { get; set; }
        public DbSet<VWINHOSINFONORMALILLEGAL> VWINHOSINFONORMALILLEGALs { get; set; }
        public DbSet<VwInHosInfoNormalOversea> VwInHosInfoNormalOverseas { get; set; }
        public DbSet<VwInHosInfoSelectDynamic> VwInHosInfoSelectDynamics { get; set; }
        public DbSet<VwInHospitalPatient> VwInHospitalPatients { get; set; }
        public DbSet<VwInIncome> VwInIncomes { get; set; }
        public DbSet<VwInIncomeReportGroup> VwInIncomeReportGroups { get; set; }
        public DbSet<VwInInvoice> VwInInvoices { get; set; }
        public DbSet<VwInInvoiceDtl> VwInInvoiceDtls { get; set; }
        public DbSet<VwInInvoiceDtlBack> VwInInvoiceDtlBacks { get; set; }
        public DbSet<VwInInvoiceDtlCj> VwInInvoiceDtlCjs { get; set; }
        public DbSet<VwInLongDrugApply> VwInLongDrugApplies { get; set; }
        public DbSet<VWInOutLocation> VWInOutLocations { get; set; }
        public DbSet<VwInPay> VwInPays { get; set; }
        public DbSet<VwInRequestBill> VwInRequestBills { get; set; }
        public DbSet<VwInRmKsDtl> VwInRmKsDtls { get; set; }
        public DbSet<VwInTempDrugApply> VwInTempDrugApplies { get; set; }
        public DbSet<VWMedInfoTableHi> VWMedInfoTableHis { get; set; }
        public DbSet<VwNfInfect> VwNfInfects { get; set; }
        public DbSet<VwNfinfect_diver> VwNfinfect_diver { get; set; }
        public DbSet<VwNfinfect_mian> VwNfinfect_mian { get; set; }
        public DbSet<VwNfinfectDrug> VwNfinfectDrugs { get; set; }
        public DbSet<VwNfinfectDrug_diver> VwNfinfectDrug_diver { get; set; }
        public DbSet<VwNfinfectIll> VwNfinfectIlls { get; set; }
        public DbSet<VwNfinfectIll_diver> VwNfinfectIll_diver { get; set; }
        public DbSet<VwNfinfectReason> VwNfinfectReasons { get; set; }
        public DbSet<VwNfinfectReason_diver> VwNfinfectReason_diver { get; set; }
        public DbSet<VwNfinfectTest> VwNfinfectTests { get; set; }
        public DbSet<VwNfinfectTest_diver> VwNfinfectTest_diver { get; set; }
        public DbSet<VwNumLabResult> VwNumLabResults { get; set; }
        public DbSet<VwOpsApply> VwOpsApplies { get; set; }
        public DbSet<VwOuAntibiotic> VwOuAntibiotics { get; set; }
        public DbSet<VwOuChinFee> VwOuChinFees { get; set; }
        public DbSet<vwOuClinicPrint> vwOuClinicPrints { get; set; }
        public DbSet<VwOuDiagSendDrug> VwOuDiagSendDrugs { get; set; }
        public DbSet<VwOuDrugCheck> VwOuDrugChecks { get; set; }
        public DbSet<VwOuDrugNurseNotIssueDtl> VwOuDrugNurseNotIssueDtls { get; set; }
        public DbSet<VwOuDrugNurseNotIssueDtlA> VwOuDrugNurseNotIssueDtlAs { get; set; }
        public DbSet<VwOuDrugNurseNotIssueDtlB> VwOuDrugNurseNotIssueDtlBs { get; set; }
        public DbSet<VwOuExecute> VwOuExecutes { get; set; }
        public DbSet<VwOuExecuteA> VwOuExecuteAs { get; set; }
        public DbSet<VwOuExecuteB> VwOuExecuteBs { get; set; }
        public DbSet<VwOuHosInfo> VwOuHosInfoes { get; set; }
        public DbSet<VwOuHosInfoSim> VwOuHosInfoSims { get; set; }
        public DbSet<VwOuIncome> VwOuIncomes { get; set; }
        public DbSet<VwOuIncome_All> VwOuIncome_All { get; set; }
        public DbSet<VwOuIncomeAll> VwOuIncomeAlls { get; set; }
        public DbSet<VwOuIncomeReportGroup> VwOuIncomeReportGroups { get; set; }
        public DbSet<VwOuInvoice> VwOuInvoices { get; set; }
        public DbSet<VwOuInvoiceDtl> VwOuInvoiceDtls { get; set; }
        public DbSet<VwOuInvoiceDtlA> VwOuInvoiceDtlAs { get; set; }
        public DbSet<VwOuInvoiceDtlB> VwOuInvoiceDtlBs { get; set; }
        public DbSet<VwOuInvoiceDtlCj> VwOuInvoiceDtlCjs { get; set; }
        public DbSet<VwOuInvoiceInvItemSum> VwOuInvoiceInvItemSums { get; set; }
        public DbSet<VwOuInvoicePay> VwOuInvoicePays { get; set; }
        public DbSet<VwOuRecipeDtl> VwOuRecipeDtls { get; set; }
        public DbSet<VwOuRecipeDtlA> VwOuRecipeDtlAs { get; set; }
        public DbSet<VwOuRecipeDtlB> VwOuRecipeDtlBs { get; set; }
        public DbSet<VwOuRegInvoice> VwOuRegInvoices { get; set; }
        public DbSet<VwOuRoomRecipe> VwOuRoomRecipes { get; set; }
        public DbSet<VwOuRoomRecipeA> VwOuRoomRecipeAs { get; set; }
        public DbSet<VwOuRoomRecipeB> VwOuRoomRecipeBs { get; set; }
        public DbSet<VwPatientIn> VwPatientIns { get; set; }
        public DbSet<VwPriceAdjust> VwPriceAdjusts { get; set; }
        public DbSet<VwPriceAdjustRm> VwPriceAdjustRms { get; set; }
        public DbSet<VwPsApplyReport> VwPsApplyReports { get; set; }
        public DbSet<VwRdPregAfter> VwRdPregAfters { get; set; }
        public DbSet<VwRdPreMarriage> VwRdPreMarriages { get; set; }
        public DbSet<VwRdWomenSurvey> VwRdWomenSurveys { get; set; }
        public DbSet<VwReferralBsPatient> VwReferralBsPatients { get; set; }
        public DbSet<VWRequestBillBackReq> VWRequestBillBackReqs { get; set; }
        public DbSet<VwResidentPatient> VwResidentPatients { get; set; }
        public DbSet<VwRmInAndOutInfo> VwRmInAndOutInfoes { get; set; }
        public DbSet<VwRmInAndOutWzInfo> VwRmInAndOutWzInfoes { get; set; }
        public DbSet<VwRmStoreLog> VwRmStoreLogs { get; set; }
        public DbSet<VWRmStore> VWRmStores { get; set; }
        public DbSet<VWRmStoresAll> VWRmStoresAlls { get; set; }
        public DbSet<vwRmstoresDay> vwRmstoresDays { get; set; }
        public DbSet<VwRmStoresRemain> VwRmStoresRemains { get; set; }
        public DbSet<VwRmZyOutDtl> VwRmZyOutDtls { get; set; }
        public DbSet<VwTrAdvice> VwTrAdvices { get; set; }
        public DbSet<VwYbInvoice> VwYbInvoices { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new aa1Map());
            modelBuilder.Configurations.Add(new AdviceAuthDtlMap());
            modelBuilder.Configurations.Add(new BaseTableRoleMap());
            modelBuilder.Configurations.Add(new bb1Map());
            modelBuilder.Configurations.Add(new BKStoreLogMap());
            modelBuilder.Configurations.Add(new BsAddrssCommittMap());
            modelBuilder.Configurations.Add(new BsAnaeItemMap());
            modelBuilder.Configurations.Add(new BsAnaeMap());
            modelBuilder.Configurations.Add(new BsAreaMap());
            modelBuilder.Configurations.Add(new BsAreaCommitteeMap());
            modelBuilder.Configurations.Add(new BsAreaPoliceStationMap());
            modelBuilder.Configurations.Add(new BsAreaProvinceMap());
            modelBuilder.Configurations.Add(new BsAreaRegionMap());
            modelBuilder.Configurations.Add(new BsBacteriaMap());
            modelBuilder.Configurations.Add(new BsBacteriaDrugMap());
            modelBuilder.Configurations.Add(new BsBacteriaGramMap());
            modelBuilder.Configurations.Add(new BsBacteriaShuMap());
            modelBuilder.Configurations.Add(new BsBacteriaStandTypeMap());
            modelBuilder.Configurations.Add(new BsBacteriaTypeMap());
            modelBuilder.Configurations.Add(new BsBaseMap());
            modelBuilder.Configurations.Add(new BsBaseCheckMap());
            modelBuilder.Configurations.Add(new BsBaseCureMap());
            modelBuilder.Configurations.Add(new BsBaseDrugMap());
            modelBuilder.Configurations.Add(new BsBaseNurseMap());
            modelBuilder.Configurations.Add(new BsBedMap());
            modelBuilder.Configurations.Add(new BsBranchMap());
            modelBuilder.Configurations.Add(new BsCareGroupMap());
            modelBuilder.Configurations.Add(new BsCertificateMap());
            modelBuilder.Configurations.Add(new BsCommitteeRoadMap());
            modelBuilder.Configurations.Add(new BsCompanyMap());
            modelBuilder.Configurations.Add(new BsCountryMap());
            modelBuilder.Configurations.Add(new BsDeptTypeMap());
            modelBuilder.Configurations.Add(new BsDiagRoomMap());
            modelBuilder.Configurations.Add(new BsDocLevelMap());
            modelBuilder.Configurations.Add(new BsDocRegTypeMap());
            modelBuilder.Configurations.Add(new BSDOCREGTYPE_TEMP_Map());
            modelBuilder.Configurations.Add(new BsDoctorMap());
            modelBuilder.Configurations.Add(new BsDoctorBackMap());
            modelBuilder.Configurations.Add(new BsDrugFormMap());
            modelBuilder.Configurations.Add(new BsDrugFormUnitMap());
            modelBuilder.Configurations.Add(new BsDrugFormUsageMap());
            modelBuilder.Configurations.Add(new BsEducationMap());
            modelBuilder.Configurations.Add(new BsEducationIllMap());
            modelBuilder.Configurations.Add(new BsEduLevelMap());
            modelBuilder.Configurations.Add(new BsEqTypeMap());
            modelBuilder.Configurations.Add(new BsExecLocationMap());
            modelBuilder.Configurations.Add(new BsFamilyMap());
            modelBuilder.Configurations.Add(new BsFeeTypeMap());
            modelBuilder.Configurations.Add(new BsFeeTypeSubMap());
            modelBuilder.Configurations.Add(new BsFixChargeMap());
            modelBuilder.Configurations.Add(new BsFluidMap());
            modelBuilder.Configurations.Add(new BsFrequencyMap());
            modelBuilder.Configurations.Add(new BsFrequencyTimeMap());
            modelBuilder.Configurations.Add(new BsFromHospitalMap());
            modelBuilder.Configurations.Add(new BsGfxeMap());
            modelBuilder.Configurations.Add(new BsGroupMap());
            modelBuilder.Configurations.Add(new BsGroupSubMap());
            modelBuilder.Configurations.Add(new BsGroupSub2Map());
            modelBuilder.Configurations.Add(new BsHealthEduRecMap());
            modelBuilder.Configurations.Add(new BsHospitalMap());
            modelBuilder.Configurations.Add(new BsHouseMap());
            modelBuilder.Configurations.Add(new BsHsFeetyMap());
            modelBuilder.Configurations.Add(new BsIllnessMap());
            modelBuilder.Configurations.Add(new BsIllness0Map());
            modelBuilder.Configurations.Add(new BsIllness177Map());
            modelBuilder.Configurations.Add(new BsIllness178Map());
            modelBuilder.Configurations.Add(new BsIllness179Map());
            modelBuilder.Configurations.Add(new BsIllness180Map());
            modelBuilder.Configurations.Add(new BsIllness181Map());
            modelBuilder.Configurations.Add(new BsIllness182Map());
            modelBuilder.Configurations.Add(new BsIllness183Map());
            modelBuilder.Configurations.Add(new BsIllness184Map());
            modelBuilder.Configurations.Add(new BsIllness185Map());
            modelBuilder.Configurations.Add(new BsIllness186Map());
            modelBuilder.Configurations.Add(new BsIllness187Map());
            modelBuilder.Configurations.Add(new BsIllness188Map());
            modelBuilder.Configurations.Add(new BsIllness189Map());
            modelBuilder.Configurations.Add(new BsIllness190Map());
            modelBuilder.Configurations.Add(new BsIllness191Map());
            modelBuilder.Configurations.Add(new BsIllness192Map());
            modelBuilder.Configurations.Add(new BsIllness193Map());
            modelBuilder.Configurations.Add(new BsIllness194Map());
            modelBuilder.Configurations.Add(new BsIllness195Map());
            modelBuilder.Configurations.Add(new BsIllness196Map());
            modelBuilder.Configurations.Add(new BsIllness197Map());
            modelBuilder.Configurations.Add(new BsIllness198Map());
            modelBuilder.Configurations.Add(new BsIllness199Map());
            modelBuilder.Configurations.Add(new BsIllness200Map());
            modelBuilder.Configurations.Add(new BsIllness201Map());
            modelBuilder.Configurations.Add(new BsIllness202Map());
            modelBuilder.Configurations.Add(new BsIllness203Map());
            modelBuilder.Configurations.Add(new BsIllness204Map());
            modelBuilder.Configurations.Add(new BsIllness205Map());
            modelBuilder.Configurations.Add(new BsIllness206Map());
            modelBuilder.Configurations.Add(new BsIllness207Map());
            modelBuilder.Configurations.Add(new BsIllness208Map());
            modelBuilder.Configurations.Add(new BsIllness209Map());
            modelBuilder.Configurations.Add(new BsIllness210Map());
            modelBuilder.Configurations.Add(new BsIllness211Map());
            modelBuilder.Configurations.Add(new BsIllness212Map());
            modelBuilder.Configurations.Add(new BsIllness213Map());
            modelBuilder.Configurations.Add(new BsIllness214Map());
            modelBuilder.Configurations.Add(new BsIllness215Map());
            modelBuilder.Configurations.Add(new BsIllness216Map());
            modelBuilder.Configurations.Add(new BsIllness217Map());
            modelBuilder.Configurations.Add(new BsIllness218Map());
            modelBuilder.Configurations.Add(new BsIllness219Map());
            modelBuilder.Configurations.Add(new BsIllness220Map());
            modelBuilder.Configurations.Add(new BsIllness221Map());
            modelBuilder.Configurations.Add(new BsIllness222Map());
            modelBuilder.Configurations.Add(new BsIllness223Map());
            modelBuilder.Configurations.Add(new BsIllness224Map());
            modelBuilder.Configurations.Add(new BsIllness225Map());
            modelBuilder.Configurations.Add(new BsIllness226Map());
            modelBuilder.Configurations.Add(new BsIllness227Map());
            modelBuilder.Configurations.Add(new BsIllness228Map());
            modelBuilder.Configurations.Add(new BsIllness229Map());
            modelBuilder.Configurations.Add(new BsIllness230Map());
            modelBuilder.Configurations.Add(new BsIllness231Map());
            modelBuilder.Configurations.Add(new BsIllness232Map());
            modelBuilder.Configurations.Add(new BsIllness233Map());
            modelBuilder.Configurations.Add(new BsIllness234Map());
            modelBuilder.Configurations.Add(new BsIllness235Map());
            modelBuilder.Configurations.Add(new BsIllness236Map());
            modelBuilder.Configurations.Add(new BsIllness237Map());
            modelBuilder.Configurations.Add(new BsIllness238Map());
            modelBuilder.Configurations.Add(new BsIllness239Map());
            modelBuilder.Configurations.Add(new BsIllness240Map());
            modelBuilder.Configurations.Add(new BsIllness241Map());
            modelBuilder.Configurations.Add(new BsIllness242Map());
            modelBuilder.Configurations.Add(new BsIllness243Map());
            modelBuilder.Configurations.Add(new BsIllness244Map());
            modelBuilder.Configurations.Add(new BsIllness245Map());
            modelBuilder.Configurations.Add(new BsIllness246Map());
            modelBuilder.Configurations.Add(new BsIllness247Map());
            modelBuilder.Configurations.Add(new BsIllness248Map());
            modelBuilder.Configurations.Add(new BsIllness249Map());
            modelBuilder.Configurations.Add(new BsIllness250Map());
            modelBuilder.Configurations.Add(new BsIllness251Map());
            modelBuilder.Configurations.Add(new BsIllness252Map());
            modelBuilder.Configurations.Add(new BsIllness253Map());
            modelBuilder.Configurations.Add(new BsIllness254Map());
            modelBuilder.Configurations.Add(new BsIllness255Map());
            modelBuilder.Configurations.Add(new BsIllness256Map());
            modelBuilder.Configurations.Add(new BsIllness257Map());
            modelBuilder.Configurations.Add(new BsIllness258Map());
            modelBuilder.Configurations.Add(new BsIllness259Map());
            modelBuilder.Configurations.Add(new BsInfectionMap());
            modelBuilder.Configurations.Add(new BsInfReasonMap());
            modelBuilder.Configurations.Add(new BsInfReasonTypeMap());
            modelBuilder.Configurations.Add(new BsInfSystemMap());
            modelBuilder.Configurations.Add(new BsInfSystemTypeMap());
            modelBuilder.Configurations.Add(new BsInvInItemMap());
            modelBuilder.Configurations.Add(new BsInvMzItemMap());
            modelBuilder.Configurations.Add(new BsItemMap());
            modelBuilder.Configurations.Add(new BsItemAttachMap());
            modelBuilder.Configurations.Add(new BSITEMCUSTOMMap());
            modelBuilder.Configurations.Add(new BSITEMCUSTOMGROUPMap());
            modelBuilder.Configurations.Add(new BsItemDrugMap());
            modelBuilder.Configurations.Add(new BsItemEquipmentMap());
            modelBuilder.Configurations.Add(new BsItemFirstPageMap());
            modelBuilder.Configurations.Add(new BsItemFrequencyMap());
            modelBuilder.Configurations.Add(new BsItemIllTypeMap());
            modelBuilder.Configurations.Add(new BsItemItemMap());
            modelBuilder.Configurations.Add(new BsItemLocationMap());
            modelBuilder.Configurations.Add(new BsItemNameMap());
            modelBuilder.Configurations.Add(new BsItemNameMultiMap());
            modelBuilder.Configurations.Add(new BsItemPacMap());
            modelBuilder.Configurations.Add(new BsItemPatTypeMap());
            modelBuilder.Configurations.Add(new BsItemPeopleMap());
            modelBuilder.Configurations.Add(new BsItemPersonMap());
            modelBuilder.Configurations.Add(new BsItemUnitMap());
            modelBuilder.Configurations.Add(new BsItemUsageMap());
            modelBuilder.Configurations.Add(new BsItemYbMap());
            modelBuilder.Configurations.Add(new BsItemYbTipMap());
            modelBuilder.Configurations.Add(new BsJCGroupMap());
            modelBuilder.Configurations.Add(new BsJCGroupAttachMap());
            modelBuilder.Configurations.Add(new BsJCGroupItemMap());
            modelBuilder.Configurations.Add(new BsLabSourceMap());
            modelBuilder.Configurations.Add(new BsLabSourceItemMap());
            modelBuilder.Configurations.Add(new BsLabSourceItem_0510Map());
            modelBuilder.Configurations.Add(new BsLessonTypeMap());
            modelBuilder.Configurations.Add(new BsLimitDocLevMap());
            modelBuilder.Configurations.Add(new BsLimitGroupMap());
            modelBuilder.Configurations.Add(new BsLocationMap());
            modelBuilder.Configurations.Add(new BsLocationRoomWindowMap());
            modelBuilder.Configurations.Add(new BsLocBranchMap());
            modelBuilder.Configurations.Add(new BsLocPatTypeMap());
            modelBuilder.Configurations.Add(new BsLocSystemMap());
            modelBuilder.Configurations.Add(new BsLocSystemSubMap());
            modelBuilder.Configurations.Add(new BsLocSystemSub2Map());
            modelBuilder.Configurations.Add(new BsManufacturerMap());
            modelBuilder.Configurations.Add(new BsMzFeetyMap());
            modelBuilder.Configurations.Add(new BsNationMap());
            modelBuilder.Configurations.Add(new BsNewMap());
            modelBuilder.Configurations.Add(new BsnotYbMap());
            modelBuilder.Configurations.Add(new BsOaGroupMap());
            modelBuilder.Configurations.Add(new BsOaGroupSubMap());
            modelBuilder.Configurations.Add(new BsOPMap());
            modelBuilder.Configurations.Add(new BsOpsItemMap());
            modelBuilder.Configurations.Add(new BsOpsRoomMap());
            modelBuilder.Configurations.Add(new BsOuMergeFeeMap());
            modelBuilder.Configurations.Add(new BsPatFingerMap());
            modelBuilder.Configurations.Add(new BsPatientMap());
            modelBuilder.Configurations.Add(new BsPatientYBIllMap());
            modelBuilder.Configurations.Add(new BsPatIllMap());
            modelBuilder.Configurations.Add(new BsPatMenuIndexMap());
            modelBuilder.Configurations.Add(new BsPatTypeMap());
            modelBuilder.Configurations.Add(new BsPatTypeLimitMap());
            modelBuilder.Configurations.Add(new BsPatTypeYbIllMap());
            modelBuilder.Configurations.Add(new BsPayWayMap());
            modelBuilder.Configurations.Add(new BsPositionMap());
            modelBuilder.Configurations.Add(new BsPriceAddMap());
            modelBuilder.Configurations.Add(new BsQuestionMap());
            modelBuilder.Configurations.Add(new BsRegPatAmountMap());
            modelBuilder.Configurations.Add(new BsRegSpanSubMap());
            modelBuilder.Configurations.Add(new BsRegTimeSpanMap());
            modelBuilder.Configurations.Add(new BsRegTypeMap());
            modelBuilder.Configurations.Add(new BsRelationMap());
            modelBuilder.Configurations.Add(new BsRoomMap());
            modelBuilder.Configurations.Add(new BsRoomGroupMap());
            modelBuilder.Configurations.Add(new BsRoomWindowMap());
            modelBuilder.Configurations.Add(new BsScoreMap());
            modelBuilder.Configurations.Add(new BsSexMap());
            modelBuilder.Configurations.Add(new BsSpecialityMap());
            modelBuilder.Configurations.Add(new BsSubjectMap());
            modelBuilder.Configurations.Add(new BsTallyGroupMap());
            modelBuilder.Configurations.Add(new BsTallyTypeMap());
            modelBuilder.Configurations.Add(new BsTestPaperMap());
            modelBuilder.Configurations.Add(new BsTubeTypeMap());
            modelBuilder.Configurations.Add(new BsUnitMap());
            modelBuilder.Configurations.Add(new BsUnitRatioMap());
            modelBuilder.Configurations.Add(new BsUsageMap());
            modelBuilder.Configurations.Add(new BsUsageItemMap());
            modelBuilder.Configurations.Add(new BsUserMap());
            modelBuilder.Configurations.Add(new BsUserEmrTemplateMap());
            modelBuilder.Configurations.Add(new BsUserHouseMap());
            modelBuilder.Configurations.Add(new BsUserImageMap());
            modelBuilder.Configurations.Add(new BsUserLocationMap());
            modelBuilder.Configurations.Add(new BsUserMenuMap());
            modelBuilder.Configurations.Add(new BsUserModuleMap());
            modelBuilder.Configurations.Add(new BsUserPointMap());
            modelBuilder.Configurations.Add(new BsUserPointDtlMap());
            modelBuilder.Configurations.Add(new BsUserRoleMap());
            modelBuilder.Configurations.Add(new BsUserRoomMap());
            modelBuilder.Configurations.Add(new BsUserWindowMap());
            modelBuilder.Configurations.Add(new BsUserWordMap());
            modelBuilder.Configurations.Add(new BsWorkTypeMap());
            modelBuilder.Configurations.Add(new BsXdGroupMap());
            modelBuilder.Configurations.Add(new BsXdGroupDtlMap());
            modelBuilder.Configurations.Add(new BsXdRpMap());
            modelBuilder.Configurations.Add(new BsXdRpDtlMap());
            modelBuilder.Configurations.Add(new BsYbCodeSpecMap());
            modelBuilder.Configurations.Add(new BsYbIllTypeMap());
            modelBuilder.Configurations.Add(new BsZyFeetyMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new CategoryLogMap());
            modelBuilder.Configurations.Add(new cc1Map());
            modelBuilder.Configurations.Add(new CkBdBankMap());
            modelBuilder.Configurations.Add(new CkBldApplyMap());
            modelBuilder.Configurations.Add(new CkBldDonateMap());
            modelBuilder.Configurations.Add(new CkBldFreeMap());
            modelBuilder.Configurations.Add(new CkBldReactionMap());
            modelBuilder.Configurations.Add(new CkBldReimbMap());
            modelBuilder.Configurations.Add(new CkBldToStationMap());
            modelBuilder.Configurations.Add(new CkBloodBackMap());
            modelBuilder.Configurations.Add(new CkBloodSendMap());
            modelBuilder.Configurations.Add(new CkBloodTypeMap());
            modelBuilder.Configurations.Add(new CkCompanyMap());
            modelBuilder.Configurations.Add(new CkCompanyCkeckMap());
            modelBuilder.Configurations.Add(new CkCompanyGroupMap());
            modelBuilder.Configurations.Add(new CkCompanyManMap());
            modelBuilder.Configurations.Add(new CkCompGroupPsApplyMap());
            modelBuilder.Configurations.Add(new CkFormulaMap());
            modelBuilder.Configurations.Add(new CkGroupMap());
            modelBuilder.Configurations.Add(new CKGROUPDEPARTMENTMap());
            modelBuilder.Configurations.Add(new CkGroupItemMap());
            modelBuilder.Configurations.Add(new CkIllAdviceMap());
            modelBuilder.Configurations.Add(new CkInFeeMap());
            modelBuilder.Configurations.Add(new CkItemMap());
            modelBuilder.Configurations.Add(new CkItemQcMap());
            modelBuilder.Configurations.Add(new CkItemRangeMap());
            modelBuilder.Configurations.Add(new CkItemResultMap());
            modelBuilder.Configurations.Add(new CkLabMap());
            modelBuilder.Configurations.Add(new CkLabDtlMap());
            modelBuilder.Configurations.Add(new CkLabMicMap());
            modelBuilder.Configurations.Add(new CkLabMicDtlMap());
            modelBuilder.Configurations.Add(new CkLabResultMap());
            modelBuilder.Configurations.Add(new CKMachineMap());
            modelBuilder.Configurations.Add(new CKMachineFluidMap());
            modelBuilder.Configurations.Add(new CKMachineImageMap());
            modelBuilder.Configurations.Add(new CKMachineNoPassageMap());
            modelBuilder.Configurations.Add(new CKMachinePassageMap());
            modelBuilder.Configurations.Add(new CKMachineResultMap());
            modelBuilder.Configurations.Add(new CKMachineResult_AMap());
            modelBuilder.Configurations.Add(new CKMachineResultDtlMap());
            modelBuilder.Configurations.Add(new CKMachineResultDtl_AMap());
            modelBuilder.Configurations.Add(new CKMachineSampleMap());
            modelBuilder.Configurations.Add(new CkMainMap());
            modelBuilder.Configurations.Add(new CkMainIllMap());
            modelBuilder.Configurations.Add(new CkProfileMap());
            modelBuilder.Configurations.Add(new CkPsApplyMap());
            modelBuilder.Configurations.Add(new CkQcControlMap());
            modelBuilder.Configurations.Add(new CkQcLotMap());
            modelBuilder.Configurations.Add(new CkQcResultMap());
            modelBuilder.Configurations.Add(new CkReportMap());
            modelBuilder.Configurations.Add(new CKReportDefineMap());
            modelBuilder.Configurations.Add(new CkResultMap());
            modelBuilder.Configurations.Add(new CkResultGroupMap());
            modelBuilder.Configurations.Add(new CkTestGroupMap());
            modelBuilder.Configurations.Add(new CkTestTypeMap());
            modelBuilder.Configurations.Add(new CkTogetherMap());
            modelBuilder.Configurations.Add(new ConfirmPreMap());
            modelBuilder.Configurations.Add(new CsAppDeptTypeMap());
            modelBuilder.Configurations.Add(new CsBigConsumeMap());
            modelBuilder.Configurations.Add(new CsCostClassMap());
            modelBuilder.Configurations.Add(new CsCostClassRelaMap());
            modelBuilder.Configurations.Add(new CsCostDetailMap());
            modelBuilder.Configurations.Add(new CsCostSubjMap());
            modelBuilder.Configurations.Add(new CsDeptCostMap());
            modelBuilder.Configurations.Add(new CsDeptCostParaMap());
            modelBuilder.Configurations.Add(new CsDeptCostTraceMap());
            modelBuilder.Configurations.Add(new CsDeptIncomeMap());
            modelBuilder.Configurations.Add(new CsIncomeDetailMap());
            modelBuilder.Configurations.Add(new CsIncomeSubjMap());
            modelBuilder.Configurations.Add(new CsInWorkLogMap());
            modelBuilder.Configurations.Add(new CsLocServiceMap());
            modelBuilder.Configurations.Add(new CsLogisticServeMap());
            modelBuilder.Configurations.Add(new CsLogisticServeDetailMap());
            modelBuilder.Configurations.Add(new CsOuWorkLogMap());
            modelBuilder.Configurations.Add(new CsParaDeptsRecMap());
            modelBuilder.Configurations.Add(new CsServerRelationMap());
            modelBuilder.Configurations.Add(new CsStatuMap());
            modelBuilder.Configurations.Add(new CsStLogisticServeMap());
            modelBuilder.Configurations.Add(new DDLExecSqlMap());
            modelBuilder.Configurations.Add(new DgDayGroupMap());
            modelBuilder.Configurations.Add(new DgDrugTipMap());
            modelBuilder.Configurations.Add(new DgIllCheckResultMap());
            modelBuilder.Configurations.Add(new DgIllCompareMap());
            modelBuilder.Configurations.Add(new DgIllCureMap());
            modelBuilder.Configurations.Add(new DgIllEmrMap());
            modelBuilder.Configurations.Add(new DgIllGroupMap());
            modelBuilder.Configurations.Add(new DgIllSymptomMap());
            modelBuilder.Configurations.Add(new DgIllXdRpMap());
            modelBuilder.Configurations.Add(new DgRoadMap());
            modelBuilder.Configurations.Add(new DgRoadDtlMap());
            modelBuilder.Configurations.Add(new DgRoadIllMap());
            modelBuilder.Configurations.Add(new DgRoadLocMap());
            modelBuilder.Configurations.Add(new DgRoadPatMap());
            modelBuilder.Configurations.Add(new DgRoadPatDtlMap());
            modelBuilder.Configurations.Add(new DgTabuMap());
            modelBuilder.Configurations.Add(new DhInAdviceLongMap());
            modelBuilder.Configurations.Add(new DhInAdviceTempMap());
            modelBuilder.Configurations.Add(new DhInvoiceDtlTempMap());
            modelBuilder.Configurations.Add(new DhInvoiceTempMap());
            modelBuilder.Configurations.Add(new DhOuRecipeMap());
            modelBuilder.Configurations.Add(new DhOuRecipeDtlMap());
            modelBuilder.Configurations.Add(new DhStoreMap());
            modelBuilder.Configurations.Add(new dtpropertyMap());
            modelBuilder.Configurations.Add(new ElBaseDtlMap());
            modelBuilder.Configurations.Add(new ElBaseFiledMap());
            modelBuilder.Configurations.Add(new ElDropDownMap());
            modelBuilder.Configurations.Add(new ElEhrMap());
            modelBuilder.Configurations.Add(new ElFormMap());
            modelBuilder.Configurations.Add(new ElFormBsPatMap());
            modelBuilder.Configurations.Add(new ElFormDtlMap());
            modelBuilder.Configurations.Add(new ElInoculateMap());
            modelBuilder.Configurations.Add(new ElPatFormMap());
            modelBuilder.Configurations.Add(new ElPatFormDrugMap());
            modelBuilder.Configurations.Add(new ElPatFormIllMap());
            modelBuilder.Configurations.Add(new ElPatFormTestMap());
            modelBuilder.Configurations.Add(new ElPatFormTranMap());
            modelBuilder.Configurations.Add(new ElPatFormValueMap());
            modelBuilder.Configurations.Add(new ElPatFormVDtlMap());
            modelBuilder.Configurations.Add(new ElPatRecordMap());
            modelBuilder.Configurations.Add(new ElPrintMap());
            modelBuilder.Configurations.Add(new ElTipMap());
            modelBuilder.Configurations.Add(new ElTipsPatMap());
            modelBuilder.Configurations.Add(new EmrReCordMap());
            modelBuilder.Configurations.Add(new EqAttachMap());
            modelBuilder.Configurations.Add(new EqCheckMap());
            modelBuilder.Configurations.Add(new EqRepairMap());
            modelBuilder.Configurations.Add(new EqTransferMap());
            modelBuilder.Configurations.Add(new EquipmentMap());
            modelBuilder.Configurations.Add(new FtDetailMap());
            modelBuilder.Configurations.Add(new FtMainMap());
            modelBuilder.Configurations.Add(new GblAutoUpdateMap());
            modelBuilder.Configurations.Add(new GblAutoUpdateOldMap());
            modelBuilder.Configurations.Add(new GblBaseTableItemMap());
            modelBuilder.Configurations.Add(new GblCatalogExceptMap());
            modelBuilder.Configurations.Add(new GblCatalogJoinMap());
            modelBuilder.Configurations.Add(new GblCatalogKeyMap());
            modelBuilder.Configurations.Add(new GblChinCharMap());
            modelBuilder.Configurations.Add(new GblCurrentUserMap());
            modelBuilder.Configurations.Add(new GblElClassMap());
            modelBuilder.Configurations.Add(new GblElGroupMap());
            modelBuilder.Configurations.Add(new GblEmailMap());
            modelBuilder.Configurations.Add(new GblEmailUserMap());
            modelBuilder.Configurations.Add(new GblEMRBranchMap());
            modelBuilder.Configurations.Add(new GblEMRCatalogMap());
            modelBuilder.Configurations.Add(new GblEMRFileMap());
            modelBuilder.Configurations.Add(new GblEMRQcGroupMap());
            modelBuilder.Configurations.Add(new GblEMRQcItemMap());
            modelBuilder.Configurations.Add(new GblFieldDescMap());
            modelBuilder.Configurations.Add(new GblFormEditMap());
            modelBuilder.Configurations.Add(new GblFuctionMap());
            modelBuilder.Configurations.Add(new GblFunDemoMap());
            modelBuilder.Configurations.Add(new GblFunTraceMap());
            modelBuilder.Configurations.Add(new GblGetSequenceNumMap());
            modelBuilder.Configurations.Add(new GblInvRegMap());
            modelBuilder.Configurations.Add(new GBLITEMGROUPMap());
            modelBuilder.Configurations.Add(new GBLITEMGROUPDTLMap());
            modelBuilder.Configurations.Add(new GblKeyLockSettingMap());
            modelBuilder.Configurations.Add(new GblLastIdMap());
            modelBuilder.Configurations.Add(new GblLatDayRunTimeMap());
            modelBuilder.Configurations.Add(new GblModiHostMap());
            modelBuilder.Configurations.Add(new GblModuleMap());
            modelBuilder.Configurations.Add(new GblMrkMap());
            modelBuilder.Configurations.Add(new GblOnlinerMap());
            modelBuilder.Configurations.Add(new GblPatientMenuMap());
            modelBuilder.Configurations.Add(new GblPhoneMsgMap());
            modelBuilder.Configurations.Add(new GblPrinterMap());
            modelBuilder.Configurations.Add(new GblQuestionMap());
            modelBuilder.Configurations.Add(new GblReportMap());
            modelBuilder.Configurations.Add(new GblReportDetailMap());
            modelBuilder.Configurations.Add(new GblReportGroupMap());
            modelBuilder.Configurations.Add(new GblRoleMap());
            modelBuilder.Configurations.Add(new GblRoleModuleMap());
            modelBuilder.Configurations.Add(new GblSettingMap());
            modelBuilder.Configurations.Add(new GblSystemMap());
            modelBuilder.Configurations.Add(new GblSystemFunctionMap());
            modelBuilder.Configurations.Add(new GblSystemMenuMap());
            modelBuilder.Configurations.Add(new GblTraceMap());
            modelBuilder.Configurations.Add(new HuAdjustMap());
            modelBuilder.Configurations.Add(new HuAdjustDtlMap());
            modelBuilder.Configurations.Add(new HuAdjustPlanMap());
            modelBuilder.Configurations.Add(new HuAdjustPlanDtlMap());
            modelBuilder.Configurations.Add(new HuBackMap());
            modelBuilder.Configurations.Add(new HuBackDtlMap());
            modelBuilder.Configurations.Add(new HuCheckMap());
            modelBuilder.Configurations.Add(new HuCheckDtlMap());
            modelBuilder.Configurations.Add(new HuCheckDtl_bak0531Map());
            modelBuilder.Configurations.Add(new HuCheckSumMap());
            modelBuilder.Configurations.Add(new HuLoseMap());
            modelBuilder.Configurations.Add(new HuLoseDtlMap());
            modelBuilder.Configurations.Add(new HuOtherInMap());
            modelBuilder.Configurations.Add(new HuOtherInDtlMap());
            modelBuilder.Configurations.Add(new HuOtherOutMap());
            modelBuilder.Configurations.Add(new HuOtherOutDtlMap());
            modelBuilder.Configurations.Add(new HuOutMap());
            modelBuilder.Configurations.Add(new HuOutDtlMap());
            modelBuilder.Configurations.Add(new HuPkMap());
            modelBuilder.Configurations.Add(new HuPkDtlMap());
            modelBuilder.Configurations.Add(new HuPyMap());
            modelBuilder.Configurations.Add(new HuPydtlMap());
            modelBuilder.Configurations.Add(new HuSplitMap());
            modelBuilder.Configurations.Add(new HuSplitInMap());
            modelBuilder.Configurations.Add(new HuSplitOutMap());
            modelBuilder.Configurations.Add(new HuStockMap());
            modelBuilder.Configurations.Add(new HuStockDtlMap());
            modelBuilder.Configurations.Add(new HuStockReqMap());
            modelBuilder.Configurations.Add(new HuStockReqdtlMap());
            modelBuilder.Configurations.Add(new HuStoreLogMap());
            modelBuilder.Configurations.Add(new HuStoreMap());
            modelBuilder.Configurations.Add(new HustoresDayMap());
            modelBuilder.Configurations.Add(new HuVoucherMap());
            modelBuilder.Configurations.Add(new HuVoucherDtlMap());
            modelBuilder.Configurations.Add(new InAdviceGroupMap());
            modelBuilder.Configurations.Add(new InAdviceLongMap());
            modelBuilder.Configurations.Add(new InAdviceLong_AMap());
            modelBuilder.Configurations.Add(new INADVICENURSEMap());
            modelBuilder.Configurations.Add(new InAdviceTempMap());
            modelBuilder.Configurations.Add(new InAdviceTemp_AMap());
            modelBuilder.Configurations.Add(new InAdviceWeekDayMap());
            modelBuilder.Configurations.Add(new InArrearAmountMap());
            modelBuilder.Configurations.Add(new INBABYBODYHEATMap());
            modelBuilder.Configurations.Add(new InBodyHeatMap());
            modelBuilder.Configurations.Add(new InCallBackMap());
            modelBuilder.Configurations.Add(new InChangeBedMap());
            modelBuilder.Configurations.Add(new InChinRicipeMap());
            modelBuilder.Configurations.Add(new InChinRicipeDtlMap());
            modelBuilder.Configurations.Add(new InChinRicipExecMap());
            modelBuilder.Configurations.Add(new InDayAddMap());
            modelBuilder.Configurations.Add(new InDayChargeMap());
            modelBuilder.Configurations.Add(new InDaySumMap());
            modelBuilder.Configurations.Add(new InDepositMap());
            modelBuilder.Configurations.Add(new InDrugReqMap());
            modelBuilder.Configurations.Add(new InDrugReqBackMap());
            modelBuilder.Configurations.Add(new InDrugReqdtlMap());
            modelBuilder.Configurations.Add(new InDrugReqdtl_AMap());
            modelBuilder.Configurations.Add(new InDrugReqdtlSkinBackMap());
            modelBuilder.Configurations.Add(new InEMRMap());
            modelBuilder.Configurations.Add(new InEmrChangeMap());
            modelBuilder.Configurations.Add(new InEmrRtfMap());
            modelBuilder.Configurations.Add(new InEmrScoreMap());
            modelBuilder.Configurations.Add(new InEmrSignMap());
            modelBuilder.Configurations.Add(new InEmrXmlMap());
            modelBuilder.Configurations.Add(new InExecuteMap());
            modelBuilder.Configurations.Add(new InExecute_AMap());
            modelBuilder.Configurations.Add(new InFeeCheckMap());
            modelBuilder.Configurations.Add(new InGfReportMap());
            modelBuilder.Configurations.Add(new InHosBedMap());
            modelBuilder.Configurations.Add(new InHosInfoMap());
            modelBuilder.Configurations.Add(new InHosMzIllMap());
            modelBuilder.Configurations.Add(new InHosOpMap());
            modelBuilder.Configurations.Add(new InHosUsageItemMap());
            modelBuilder.Configurations.Add(new InInvoiceMap());
            modelBuilder.Configurations.Add(new InInvoiceDtlMap());
            modelBuilder.Configurations.Add(new InInvoiceDtl_AMap());
            modelBuilder.Configurations.Add(new InInvoiceDtlBedMap());
            modelBuilder.Configurations.Add(new InInvoiceDtlCancelMap());
            modelBuilder.Configurations.Add(new InInvoiceDtlChkMap());
            modelBuilder.Configurations.Add(new InInvoiceDtlDumpMap());
            modelBuilder.Configurations.Add(new InInvoiceDtlTempMap());
            modelBuilder.Configurations.Add(new InInvoiceFeetySumMap());
            modelBuilder.Configurations.Add(new InInvoiceInvItemSumMap());
            modelBuilder.Configurations.Add(new InInvoYBMap());
            modelBuilder.Configurations.Add(new InLocNoPayMap());
            modelBuilder.Configurations.Add(new InLogInHospitalMap());
            modelBuilder.Configurations.Add(new InLogOutHospitalMap());
            modelBuilder.Configurations.Add(new InLogOutLocationMap());
            modelBuilder.Configurations.Add(new InLogStatusInMap());
            modelBuilder.Configurations.Add(new InNotAttachMap());
            modelBuilder.Configurations.Add(new InOpsSumMap());
            modelBuilder.Configurations.Add(new InOutLocationMap());
            modelBuilder.Configurations.Add(new InPatFeesListMap());
            modelBuilder.Configurations.Add(new INPATFEESLIST_JMap());
            modelBuilder.Configurations.Add(new InPatLogMap());
            modelBuilder.Configurations.Add(new InPayMap());
            modelBuilder.Configurations.Add(new InRecFirstPageMap());
            modelBuilder.Configurations.Add(new InRmKsDtlMap());
            modelBuilder.Configurations.Add(new InWorkLogMap());
            modelBuilder.Configurations.Add(new InYBBalanceMap());
            modelBuilder.Configurations.Add(new LogMap());
            modelBuilder.Configurations.Add(new main_aaMap());
            modelBuilder.Configurations.Add(new NfInfectMap());
            modelBuilder.Configurations.Add(new NfInfectDrugMap());
            modelBuilder.Configurations.Add(new NfInfectIllMap());
            modelBuilder.Configurations.Add(new NfInfectReasonMap());
            modelBuilder.Configurations.Add(new NfInfectTestMap());
            modelBuilder.Configurations.Add(new NfInfectTestBacteriaMap());
            modelBuilder.Configurations.Add(new NrPlanMap());
            modelBuilder.Configurations.Add(new NrPregnancyMap());
            modelBuilder.Configurations.Add(new NrPregnancyDtlMap());
            modelBuilder.Configurations.Add(new NrRecordMap());
            modelBuilder.Configurations.Add(new OaDocAuthMap());
            modelBuilder.Configurations.Add(new OaDocFileMap());
            modelBuilder.Configurations.Add(new OaDocKeyMap());
            modelBuilder.Configurations.Add(new OaDocReaderMap());
            modelBuilder.Configurations.Add(new OaDocumentMap());
            modelBuilder.Configurations.Add(new OaScheduleMap());
            modelBuilder.Configurations.Add(new OpsApplyMap());
            modelBuilder.Configurations.Add(new OpsChargeMap());
            modelBuilder.Configurations.Add(new OpsEventMap());
            modelBuilder.Configurations.Add(new OpsManMap());
            modelBuilder.Configurations.Add(new OpsNurseMap());
            modelBuilder.Configurations.Add(new OpsPostTreatMap());
            modelBuilder.Configurations.Add(new OtBidMap());
            modelBuilder.Configurations.Add(new OtBidDtlMap());
            modelBuilder.Configurations.Add(new OuClincDiagMap());
            modelBuilder.Configurations.Add(new OuClinicFirstMap());
            modelBuilder.Configurations.Add(new OuDayReportMap());
            modelBuilder.Configurations.Add(new OuDiagCallMap());
            modelBuilder.Configurations.Add(new OuDocRegTypeMap());
            modelBuilder.Configurations.Add(new OuDocSpanSubMap());
            modelBuilder.Configurations.Add(new OuExecuteMap());
            modelBuilder.Configurations.Add(new OuExecuteBackMap());
            modelBuilder.Configurations.Add(new OuExecuteDtlMap());
            modelBuilder.Configurations.Add(new OuExecuteDtl_AMap());
            modelBuilder.Configurations.Add(new OuGfbxReportMap());
            modelBuilder.Configurations.Add(new OuGFReportMap());
            modelBuilder.Configurations.Add(new OuHosInfoMap());
            modelBuilder.Configurations.Add(new OuIllReportMap());
            modelBuilder.Configurations.Add(new OuInCarMap());
            modelBuilder.Configurations.Add(new OuInvoiceMap());
            modelBuilder.Configurations.Add(new OuInvoiceDtlMap());
            modelBuilder.Configurations.Add(new OuInvoiceDtl_AMap());
            modelBuilder.Configurations.Add(new OuInvoiceFeetySumMap());
            modelBuilder.Configurations.Add(new OuInvoiceInvItemSumMap());
            modelBuilder.Configurations.Add(new OuInvoicePayMap());
            modelBuilder.Configurations.Add(new ouinvoybMap());
            modelBuilder.Configurations.Add(new OuLeadRegMap());
            modelBuilder.Configurations.Add(new OulInvoiceRegMap());
            modelBuilder.Configurations.Add(new OuNotAttachMap());
            modelBuilder.Configurations.Add(new OuRecipeMap());
            modelBuilder.Configurations.Add(new OuRecipeBackMap());
            modelBuilder.Configurations.Add(new OuRecipeChinMap());
            modelBuilder.Configurations.Add(new OuRecipeDtlMap());
            modelBuilder.Configurations.Add(new OuRecipeDtl_AMap());
            modelBuilder.Configurations.Add(new OuRecipeTempMap());
            modelBuilder.Configurations.Add(new out_t_jczxxxMap());
            modelBuilder.Configurations.Add(new OutMedTableHiMap());
            modelBuilder.Configurations.Add(new OuTransferHospMap());
            modelBuilder.Configurations.Add(new PatCardFeeMap());
            modelBuilder.Configurations.Add(new PlItemMap());
            modelBuilder.Configurations.Add(new PlProjectMap());
            modelBuilder.Configurations.Add(new PlProjectItemMap());
            modelBuilder.Configurations.Add(new PsApplyReportMap());
            modelBuilder.Configurations.Add(new PsDiagDoctorMap());
            modelBuilder.Configurations.Add(new PsDiagMeetingMap());
            modelBuilder.Configurations.Add(new PsDrugActionMap());
            modelBuilder.Configurations.Add(new PsExecuteMap());
            modelBuilder.Configurations.Add(new RdBrainDeadMap());
            modelBuilder.Configurations.Add(new RdCancerMap());
            modelBuilder.Configurations.Add(new RdChangeOutMap());
            modelBuilder.Configurations.Add(new RdContractMap());
            modelBuilder.Configurations.Add(new RdCurePlanMap());
            modelBuilder.Configurations.Add(new RdFollowMap());
            modelBuilder.Configurations.Add(new RdHurtMap());
            modelBuilder.Configurations.Add(new RdInfectiouMap());
            modelBuilder.Configurations.Add(new RdInfectStdMap());
            modelBuilder.Configurations.Add(new RdLessonMap());
            modelBuilder.Configurations.Add(new RdLessonManMap());
            modelBuilder.Configurations.Add(new RdLiverMap());
            modelBuilder.Configurations.Add(new RdNewBirthMap());
            modelBuilder.Configurations.Add(new Report_TableMap());
            modelBuilder.Configurations.Add(new RmAdjustMap());
            modelBuilder.Configurations.Add(new RmAdjustDtlMap());
            modelBuilder.Configurations.Add(new RmAppDrugMap());
            modelBuilder.Configurations.Add(new RmAppDrugDtlMap());
            modelBuilder.Configurations.Add(new RmApplbackMap());
            modelBuilder.Configurations.Add(new RmApplbackDtlMap());
            modelBuilder.Configurations.Add(new RmBackMap());
            modelBuilder.Configurations.Add(new RmBackDetailMap());
            modelBuilder.Configurations.Add(new RmCheckMap());
            modelBuilder.Configurations.Add(new RmCheckDtlMap());
            modelBuilder.Configurations.Add(new RmCheckGroupDtlMap());
            modelBuilder.Configurations.Add(new RmCheckSumMap());
            modelBuilder.Configurations.Add(new RmGroupPrintNumMap());
            modelBuilder.Configurations.Add(new RmKOutDtlMap());
            modelBuilder.Configurations.Add(new RmKsBackMap());
            modelBuilder.Configurations.Add(new RmKsBackDtlMap());
            modelBuilder.Configurations.Add(new RmKsOutMap());
            modelBuilder.Configurations.Add(new RmLoseMap());
            modelBuilder.Configurations.Add(new RmLoseDtlMap());
            modelBuilder.Configurations.Add(new RmMoveMap());
            modelBuilder.Configurations.Add(new RmMoveDtlMap());
            modelBuilder.Configurations.Add(new RmOtherInMap());
            modelBuilder.Configurations.Add(new RmOtherInDtlMap());
            modelBuilder.Configurations.Add(new RmOutMap());
            modelBuilder.Configurations.Add(new RmOutDtlMap());
            modelBuilder.Configurations.Add(new RmOutOthMap());
            modelBuilder.Configurations.Add(new RmOutOthDtlMap());
            modelBuilder.Configurations.Add(new RmPkMap());
            modelBuilder.Configurations.Add(new RmPkDtlMap());
            modelBuilder.Configurations.Add(new RmPyMap());
            modelBuilder.Configurations.Add(new RmPyDtlMap());
            modelBuilder.Configurations.Add(new RmSendingMap());
            modelBuilder.Configurations.Add(new RmSplitMap());
            modelBuilder.Configurations.Add(new RmSplitInMap());
            modelBuilder.Configurations.Add(new RmSplitOutMap());
            modelBuilder.Configurations.Add(new RmStoreLogMap());
            modelBuilder.Configurations.Add(new RmstoreMap());
            modelBuilder.Configurations.Add(new rmstores_bak0531Map());
            modelBuilder.Configurations.Add(new RmstoresDayMap());
            modelBuilder.Configurations.Add(new RmstoreStockNumMap());
            modelBuilder.Configurations.Add(new RmstoreStockNum2Map());
            modelBuilder.Configurations.Add(new RmUnderLineMap());
            modelBuilder.Configurations.Add(new RmZyBackMap());
            modelBuilder.Configurations.Add(new RmZyBackDtlMap());
            modelBuilder.Configurations.Add(new RmZyOutMap());
            modelBuilder.Configurations.Add(new RmZyOutDtlMap());
            modelBuilder.Configurations.Add(new RTRJKREPORTMap());
            modelBuilder.Configurations.Add(new TmpEmrMap());
            modelBuilder.Configurations.Add(new TmpItemMap());
            modelBuilder.Configurations.Add(new TmpMyPatMap());
            modelBuilder.Configurations.Add(new TmpOuEmrMap());
            modelBuilder.Configurations.Add(new TmpWordDetailMap());
            modelBuilder.Configurations.Add(new TraceMap());
            modelBuilder.Configurations.Add(new TrAdviceMap());
            modelBuilder.Configurations.Add(new TrDoctorEmrMap());
            modelBuilder.Configurations.Add(new TrInHosInfoMap());
            modelBuilder.Configurations.Add(new TrLocDayRatioMap());
            modelBuilder.Configurations.Add(new TrPractiseMap());
            modelBuilder.Configurations.Add(new TrSchedulerMap());
            modelBuilder.Configurations.Add(new TrScheLineMap());
            modelBuilder.Configurations.Add(new YBChargeLogMap());
            modelBuilder.Configurations.Add(new YbPatSeqMap());
            modelBuilder.Configurations.Add(new YbQueryMap());
            modelBuilder.Configurations.Add(new ZXYBMXDTLMap());
            modelBuilder.Configurations.Add(new ZXYbPatMap());
            modelBuilder.Configurations.Add(new His_eng_cfMap());
            modelBuilder.Configurations.Add(new His_eng_cf_itemMap());
            modelBuilder.Configurations.Add(new his_eng_orderMap());
            modelBuilder.Configurations.Add(new his_eng_order_diagnoseMap());
            modelBuilder.Configurations.Add(new his_eng_order_drugMap());
            modelBuilder.Configurations.Add(new his_eng_order_examMap());
            modelBuilder.Configurations.Add(new his_eng_order_operationMap());
            modelBuilder.Configurations.Add(new mdc_drug_match_info_viewMap());
            modelBuilder.Configurations.Add(new mdc_route_match_info_viewMap());
            modelBuilder.Configurations.Add(new out_v_jcMap());
            modelBuilder.Configurations.Add(new OUT_V_JYMap());
            modelBuilder.Configurations.Add(new OUT_V_JY_ZBMap());
            modelBuilder.Configurations.Add(new OUT_V_PACSMap());
            modelBuilder.Configurations.Add(new OUT_V_PACS_ZBMap());
            modelBuilder.Configurations.Add(new syssegmentMap());
            modelBuilder.Configurations.Add(new TB_CIS_Outpatient_PrescriptionMap());
            modelBuilder.Configurations.Add(new TB_CIS_Outpatient_RegistrationMap());
            modelBuilder.Configurations.Add(new TB_CIS_Outpatient_Visiting_RecordMap());
            modelBuilder.Configurations.Add(new TB_CIS_OutpatientDrAdvice_DetailMap());
            modelBuilder.Configurations.Add(new TB_HIS_Fee_DetailMap());
            modelBuilder.Configurations.Add(new TB_HIS_Fee_RecordMap());
            modelBuilder.Configurations.Add(new TB_Patient_InformationMap());
            modelBuilder.Configurations.Add(new View_RdInfectiousMap());
            modelBuilder.Configurations.Add(new VIEW1Map());
            modelBuilder.Configurations.Add(new VIEW2Map());
            modelBuilder.Configurations.Add(new viewTestResultCumulateMap());
            modelBuilder.Configurations.Add(new Vw_BingrzlMap());
            modelBuilder.Configurations.Add(new Vw_ChinRecipe_Detail_PrintMap());
            modelBuilder.Configurations.Add(new Vw_ChinRecipe_Detail_PrintAMap());
            modelBuilder.Configurations.Add(new Vw_ChinRecipe_Detail_PrintBMap());
            modelBuilder.Configurations.Add(new Vw_CKMachineResult_AMap());
            modelBuilder.Configurations.Add(new Vw_CKMachineResult_BMap());
            modelBuilder.Configurations.Add(new Vw_CKMachineResultDtl_AMap());
            modelBuilder.Configurations.Add(new Vw_CKMachineResultDtl_BMap());
            modelBuilder.Configurations.Add(new VW_CkProfileMap());
            modelBuilder.Configurations.Add(new vw_DI_CkLabMap());
            modelBuilder.Configurations.Add(new Vw_DI_CkLabResultMap());
            modelBuilder.Configurations.Add(new Vw_DI_ClincDiagMap());
            modelBuilder.Configurations.Add(new Vw_DI_EMR_HaveToMap());
            modelBuilder.Configurations.Add(new Vw_DI_InAdviceMap());
            modelBuilder.Configurations.Add(new Vw_DI_OuHosInfoMap());
            modelBuilder.Configurations.Add(new Vw_DI_OuInvoiceSumMap());
            modelBuilder.Configurations.Add(new Vw_DI_OurecipeDtlMap());
            modelBuilder.Configurations.Add(new Vw_DoctorInSumMap());
            modelBuilder.Configurations.Add(new Vw_DoctorOuSumMap());
            modelBuilder.Configurations.Add(new Vw_FlightCheckingMap());
            modelBuilder.Configurations.Add(new Vw_FlightExamineMap());
            modelBuilder.Configurations.Add(new Vw_FlightExamineResultMap());
            modelBuilder.Configurations.Add(new Vw_FlightInDepartmentMap());
            modelBuilder.Configurations.Add(new Vw_FlightInHosInfoMap());
            modelBuilder.Configurations.Add(new Vw_FlightPatientMap());
            modelBuilder.Configurations.Add(new Vw_FlightReceipeMap());
            modelBuilder.Configurations.Add(new Vw_FlightSurgeryLayoutMap());
            modelBuilder.Configurations.Add(new Vw_FlightSurgeryNoticeMap());
            modelBuilder.Configurations.Add(new Vw_FlightUserMap());
            modelBuilder.Configurations.Add(new VW_HisInPatientMap());
            modelBuilder.Configurations.Add(new VW_HisOutPatientMap());
            modelBuilder.Configurations.Add(new Vw_InAdviceLong_AMap());
            modelBuilder.Configurations.Add(new Vw_InAdviceLong_BMap());
            modelBuilder.Configurations.Add(new Vw_InAdviceTemp_AMap());
            modelBuilder.Configurations.Add(new Vw_InAdviceTemp_BMap());
            modelBuilder.Configurations.Add(new VW_InChinRicipeSendMap());
            modelBuilder.Configurations.Add(new Vw_InDaySumMap());
            modelBuilder.Configurations.Add(new Vw_InDrugReqdtl_AMap());
            modelBuilder.Configurations.Add(new Vw_InDrugReqdtl_BMap());
            modelBuilder.Configurations.Add(new Vw_InExecute_AMap());
            modelBuilder.Configurations.Add(new Vw_InExecute_BMap());
            modelBuilder.Configurations.Add(new vw_inhosinfoxxMap());
            modelBuilder.Configurations.Add(new Vw_InInvoiceDtl_AMap());
            modelBuilder.Configurations.Add(new Vw_InInvoiceDtl_BMap());
            modelBuilder.Configurations.Add(new Vw_InOperDayInvoiceMap());
            modelBuilder.Configurations.Add(new Vw_InWorkLogMap());
            modelBuilder.Configurations.Add(new Vw_InWorkLog_hzMap());
            modelBuilder.Configurations.Add(new Vw_ItemTraceMap());
            modelBuilder.Configurations.Add(new Vw_mmzy_mzfpMap());
            modelBuilder.Configurations.Add(new Vw_mmzy_mzghMap());
            modelBuilder.Configurations.Add(new Vw_mmzy_mztfMap());
            modelBuilder.Configurations.Add(new Vw_mmzy_mzzlrc_fyMap());
            modelBuilder.Configurations.Add(new Vw_MzgnkssrMap());
            modelBuilder.Configurations.Add(new Vw_mzkssftjMap());
            modelBuilder.Configurations.Add(new Vw_MzLocationFeePayedMap());
            modelBuilder.Configurations.Add(new Vw_OuExecuteDtl_AMap());
            modelBuilder.Configurations.Add(new Vw_OuExecuteDtl_BMap());
            modelBuilder.Configurations.Add(new Vw_OuInvoiceDtl_AMap());
            modelBuilder.Configurations.Add(new Vw_OuInvoiceDtl_BMap());
            modelBuilder.Configurations.Add(new Vw_OuOperDayInvoiceMap());
            modelBuilder.Configurations.Add(new Vw_OuRecipeDtl_AMap());
            modelBuilder.Configurations.Add(new Vw_OuRecipeDtl_BMap());
            modelBuilder.Configurations.Add(new Vw_PatientInNTimeMap());
            modelBuilder.Configurations.Add(new Vw_Recipe_Detail_PrintMap());
            modelBuilder.Configurations.Add(new Vw_Recipe_Detail_Print1Map());
            modelBuilder.Configurations.Add(new Vw_Recipe_Xdrp_PrintMap());
            modelBuilder.Configurations.Add(new VW_RKBillInfoMap());
            modelBuilder.Configurations.Add(new Vw_sssfMap());
            modelBuilder.Configurations.Add(new Vw_sstjMap());
            modelBuilder.Configurations.Add(new Vw_TraceLogMap());
            modelBuilder.Configurations.Add(new Vw_xxk_ryrsbcsMap());
            modelBuilder.Configurations.Add(new Vw_yfmzgzlMap());
            modelBuilder.Configurations.Add(new Vw_yfzygzl_zcyMap());
            modelBuilder.Configurations.Add(new Vw_yingxjc_MZMap());
            modelBuilder.Configurations.Add(new Vw_yingxjc_ZYMap());
            modelBuilder.Configurations.Add(new Vw_yptjMap());
            modelBuilder.Configurations.Add(new Vw_ypxxMap());
            modelBuilder.Configurations.Add(new Vw_yszlMap());
            modelBuilder.Configurations.Add(new Vw_zy_ybbrfyMap());
            modelBuilder.Configurations.Add(new Vw_zyanjMap());
            modelBuilder.Configurations.Add(new Vw_zybrxmhzMap());
            modelBuilder.Configurations.Add(new Vw_zybryecxMap());
            modelBuilder.Configurations.Add(new Vw_zybryskmxbMap());
            modelBuilder.Configurations.Add(new Vw_zycybrjkMap());
            modelBuilder.Configurations.Add(new Vw_zycybrxxMap());
            modelBuilder.Configurations.Add(new Vw_zyFreeMap());
            modelBuilder.Configurations.Add(new Vw_zygnkssrMap());
            modelBuilder.Configurations.Add(new Vw_ZykssftjMap());
            modelBuilder.Configurations.Add(new Vw_ZyLocationFeeMap());
            modelBuilder.Configurations.Add(new Vw_ZyLocationFeePayedMap());
            modelBuilder.Configurations.Add(new Vw_zyrydjxxMap());
            modelBuilder.Configurations.Add(new Vw_zyrydjxx_brlyMap());
            modelBuilder.Configurations.Add(new Vw_zyrydjxx_czMap());
            modelBuilder.Configurations.Add(new Vw_zyrydjxx_ddybsylMap());
            modelBuilder.Configurations.Add(new Vw_zyrydjxx_mnnhMap());
            modelBuilder.Configurations.Add(new Vw_zyrydjxx_syybMap());
            modelBuilder.Configurations.Add(new Vw_zyrydjxx_ybMap());
            modelBuilder.Configurations.Add(new Vw_zysfczjcxMap());
            modelBuilder.Configurations.Add(new Vw_zysfflhzMap());
            modelBuilder.Configurations.Add(new Vw_zysfxmhbMap());
            modelBuilder.Configurations.Add(new Vw_zysfxmhb_ksMap());
            modelBuilder.Configurations.Add(new Vw_zysfxmmxMap());
            modelBuilder.Configurations.Add(new Vw_zysfxmmx_ybMap());
            modelBuilder.Configurations.Add(new Vw_zyzybrxxMap());
            modelBuilder.Configurations.Add(new VwBedMap());
            modelBuilder.Configurations.Add(new VwBedListMap());
            modelBuilder.Configurations.Add(new VwBedSearchMap());
            modelBuilder.Configurations.Add(new vwBsItemMap());
            modelBuilder.Configurations.Add(new VwBsItemMiniMap());
            modelBuilder.Configurations.Add(new VwBsPatientMap());
            modelBuilder.Configurations.Add(new VwBsPatientForInHospitalMap());
            modelBuilder.Configurations.Add(new VwBsPatMenuIndexMap());
            modelBuilder.Configurations.Add(new VwBsPatTypeMap());
            modelBuilder.Configurations.Add(new VwBsXdRpMap());
            modelBuilder.Configurations.Add(new VwCkLabMap());
            modelBuilder.Configurations.Add(new VwCkLabResultMap());
            modelBuilder.Configurations.Add(new VwCkMachineSampleMap());
            modelBuilder.Configurations.Add(new VwCkMachineTestMap());
            modelBuilder.Configurations.Add(new VwCkPatientResultMap());
            modelBuilder.Configurations.Add(new VwCkQcResultMap());
            modelBuilder.Configurations.Add(new VwCkResultMap());
            modelBuilder.Configurations.Add(new VwCommitteeFamilyMap());
            modelBuilder.Configurations.Add(new VwEquipmentMap());
            modelBuilder.Configurations.Add(new VwEquipmentRepairMap());
            modelBuilder.Configurations.Add(new VwGblEMRCatalogMap());
            modelBuilder.Configurations.Add(new VwGnKsFeeMap());
            modelBuilder.Configurations.Add(new VwHuInAndOutInfoMap());
            modelBuilder.Configurations.Add(new VwHuInAndOutInfo_WzMap());
            modelBuilder.Configurations.Add(new VwHuOutBackMap());
            modelBuilder.Configurations.Add(new VwHuStoreLogMap());
            modelBuilder.Configurations.Add(new VwHuStoreLog_tempMap());
            modelBuilder.Configurations.Add(new VwHuStoreLog_WzMap());
            modelBuilder.Configurations.Add(new VWHuStoreMap());
            modelBuilder.Configurations.Add(new vwHustoresDayMap());
            modelBuilder.Configurations.Add(new VWHuStoresFKMap());
            modelBuilder.Configurations.Add(new VwHuStoresHasNumMap());
            modelBuilder.Configurations.Add(new VwHustoresRemainMap());
            modelBuilder.Configurations.Add(new VwInAndOuInvoiceMap());
            modelBuilder.Configurations.Add(new VwInAntibioticMap());
            modelBuilder.Configurations.Add(new VwInChinFeeMap());
            modelBuilder.Configurations.Add(new VwInDepositMap());
            modelBuilder.Configurations.Add(new VwInDepositPayMap());
            modelBuilder.Configurations.Add(new VwInDoctorAdviceMap());
            modelBuilder.Configurations.Add(new VwInDoctorAdviceLongTempMap());
            modelBuilder.Configurations.Add(new VwInDrugCheckMap());
            modelBuilder.Configurations.Add(new VwInDrugIssueSendMap());
            modelBuilder.Configurations.Add(new VwInDrugIssueSendLongAloneMap());
            modelBuilder.Configurations.Add(new VwInExecuteMap());
            modelBuilder.Configurations.Add(new VwInExecuteLateMap());
            modelBuilder.Configurations.Add(new VwInHosInfoMap());
            modelBuilder.Configurations.Add(new VwInHosInfoNormalMap());
            modelBuilder.Configurations.Add(new VWINHOSINFONORMALILLEGALMap());
            modelBuilder.Configurations.Add(new VwInHosInfoNormalOverseaMap());
            modelBuilder.Configurations.Add(new VwInHosInfoSelectDynamicMap());
            modelBuilder.Configurations.Add(new VwInHospitalPatientMap());
            modelBuilder.Configurations.Add(new VwInIncomeMap());
            modelBuilder.Configurations.Add(new VwInIncomeReportGroupMap());
            modelBuilder.Configurations.Add(new VwInInvoiceMap());
            modelBuilder.Configurations.Add(new VwInInvoiceDtlMap());
            modelBuilder.Configurations.Add(new VwInInvoiceDtlBackMap());
            modelBuilder.Configurations.Add(new VwInInvoiceDtlCjMap());
            modelBuilder.Configurations.Add(new VwInLongDrugApplyMap());
            modelBuilder.Configurations.Add(new VWInOutLocationMap());
            modelBuilder.Configurations.Add(new VwInPayMap());
            modelBuilder.Configurations.Add(new VwInRequestBillMap());
            modelBuilder.Configurations.Add(new VwInRmKsDtlMap());
            modelBuilder.Configurations.Add(new VwInTempDrugApplyMap());
            modelBuilder.Configurations.Add(new VWMedInfoTableHiMap());
            modelBuilder.Configurations.Add(new VwNfInfectMap());
            modelBuilder.Configurations.Add(new VwNfinfect_diverMap());
            modelBuilder.Configurations.Add(new VwNfinfect_mianMap());
            modelBuilder.Configurations.Add(new VwNfinfectDrugMap());
            modelBuilder.Configurations.Add(new VwNfinfectDrug_diverMap());
            modelBuilder.Configurations.Add(new VwNfinfectIllMap());
            modelBuilder.Configurations.Add(new VwNfinfectIll_diverMap());
            modelBuilder.Configurations.Add(new VwNfinfectReasonMap());
            modelBuilder.Configurations.Add(new VwNfinfectReason_diverMap());
            modelBuilder.Configurations.Add(new VwNfinfectTestMap());
            modelBuilder.Configurations.Add(new VwNfinfectTest_diverMap());
            modelBuilder.Configurations.Add(new VwNumLabResultMap());
            modelBuilder.Configurations.Add(new VwOpsApplyMap());
            modelBuilder.Configurations.Add(new VwOuAntibioticMap());
            modelBuilder.Configurations.Add(new VwOuChinFeeMap());
            modelBuilder.Configurations.Add(new vwOuClinicPrintMap());
            modelBuilder.Configurations.Add(new VwOuDiagSendDrugMap());
            modelBuilder.Configurations.Add(new VwOuDrugCheckMap());
            modelBuilder.Configurations.Add(new VwOuDrugNurseNotIssueDtlMap());
            modelBuilder.Configurations.Add(new VwOuDrugNurseNotIssueDtlAMap());
            modelBuilder.Configurations.Add(new VwOuDrugNurseNotIssueDtlBMap());
            modelBuilder.Configurations.Add(new VwOuExecuteMap());
            modelBuilder.Configurations.Add(new VwOuExecuteAMap());
            modelBuilder.Configurations.Add(new VwOuExecuteBMap());
            modelBuilder.Configurations.Add(new VwOuHosInfoMap());
            modelBuilder.Configurations.Add(new VwOuHosInfoSimMap());
            modelBuilder.Configurations.Add(new VwOuIncomeMap());
            modelBuilder.Configurations.Add(new VwOuIncome_AllMap());
            modelBuilder.Configurations.Add(new VwOuIncomeAllMap());
            modelBuilder.Configurations.Add(new VwOuIncomeReportGroupMap());
            modelBuilder.Configurations.Add(new VwOuInvoiceMap());
            modelBuilder.Configurations.Add(new VwOuInvoiceDtlMap());
            modelBuilder.Configurations.Add(new VwOuInvoiceDtlAMap());
            modelBuilder.Configurations.Add(new VwOuInvoiceDtlBMap());
            modelBuilder.Configurations.Add(new VwOuInvoiceDtlCjMap());
            modelBuilder.Configurations.Add(new VwOuInvoiceInvItemSumMap());
            modelBuilder.Configurations.Add(new VwOuInvoicePayMap());
            modelBuilder.Configurations.Add(new VwOuRecipeDtlMap());
            modelBuilder.Configurations.Add(new VwOuRecipeDtlAMap());
            modelBuilder.Configurations.Add(new VwOuRecipeDtlBMap());
            modelBuilder.Configurations.Add(new VwOuRegInvoiceMap());
            modelBuilder.Configurations.Add(new VwOuRoomRecipeMap());
            modelBuilder.Configurations.Add(new VwOuRoomRecipeAMap());
            modelBuilder.Configurations.Add(new VwOuRoomRecipeBMap());
            modelBuilder.Configurations.Add(new VwPatientInMap());
            modelBuilder.Configurations.Add(new VwPriceAdjustMap());
            modelBuilder.Configurations.Add(new VwPriceAdjustRmMap());
            modelBuilder.Configurations.Add(new VwPsApplyReportMap());
            modelBuilder.Configurations.Add(new VwRdPregAfterMap());
            modelBuilder.Configurations.Add(new VwRdPreMarriageMap());
            modelBuilder.Configurations.Add(new VwRdWomenSurveyMap());
            modelBuilder.Configurations.Add(new VwReferralBsPatientMap());
            modelBuilder.Configurations.Add(new VWRequestBillBackReqMap());
            modelBuilder.Configurations.Add(new VwResidentPatientMap());
            modelBuilder.Configurations.Add(new VwRmInAndOutInfoMap());
            modelBuilder.Configurations.Add(new VwRmInAndOutWzInfoMap());
            modelBuilder.Configurations.Add(new VwRmStoreLogMap());
            modelBuilder.Configurations.Add(new VWRmStoreMap());
            modelBuilder.Configurations.Add(new VWRmStoresAllMap());
            modelBuilder.Configurations.Add(new vwRmstoresDayMap());
            modelBuilder.Configurations.Add(new VwRmStoresRemainMap());
            modelBuilder.Configurations.Add(new VwRmZyOutDtlMap());
            modelBuilder.Configurations.Add(new VwTrAdviceMap());
            modelBuilder.Configurations.Add(new VwYbInvoiceMap());
        }
    }
}
