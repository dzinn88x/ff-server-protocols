using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001F70 RID: 8048
	[Token(Token = "0x2001F70")]
	public class UIModelMVP : UIBaseModel, IBigEventModel
	{
		// Token: 0x0600B1F0 RID: 45552 RVA: 0x00032238 File Offset: 0x00030438
		[Token(Token = "0x600B1F0")]
		[Address(RVA = "0x1651CA0", Offset = "0x1651CA0", VA = "0x7BBBE51CA0", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600B1F1 RID: 45553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1F1")]
		[Address(RVA = "0x1651CA8", Offset = "0x1651CA8", VA = "0x7BBBE51CA8")]
		public void RequestDiceGameConfig()
		{
		}

		// Token: 0x0600B1F2 RID: 45554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1F2")]
		[Address(RVA = "0x1651E4C", Offset = "0x1651E4C", VA = "0x7BBBE51E4C")]
		public void RequestDiceGameInfo()
		{
		}

		// Token: 0x0600B1F3 RID: 45555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1F3")]
		[Address(RVA = "0x1651FF0", Offset = "0x1651FF0", VA = "0x7BBBE51FF0")]
		public void RequestDiceGameRollDice()
		{
		}

		// Token: 0x0600B1F4 RID: 45556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1F4")]
		[Address(RVA = "0x1652210", Offset = "0x1652210", VA = "0x7BBBE52210")]
		public void RequestDiceGameChooseEventBranch(uint choose)
		{
		}

		// Token: 0x0600B1F5 RID: 45557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1F5")]
		[Address(RVA = "0x1652434", Offset = "0x1652434", VA = "0x7BBBE52434")]
		public void RequestClaimPhaseReward(uint processId)
		{
		}

		// Token: 0x0600B1F6 RID: 45558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1F6")]
		[Address(RVA = "0x1652648", Offset = "0x1652648", VA = "0x7BBBE52648")]
		public void RequestDiceGamePhaseRwdInfo()
		{
		}

		// Token: 0x0600B1F7 RID: 45559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1F7")]
		[Address(RVA = "0x16527EC", Offset = "0x16527EC", VA = "0x7BBBE527EC")]
		private void ProcessDiceGameConfig(CSGetMonopolyConfigRes res)
		{
		}

		// Token: 0x0600B1F8 RID: 45560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1F8")]
		[Address(RVA = "0x1652AA0", Offset = "0x1652AA0", VA = "0x7BBBE52AA0")]
		private void ProcessDiceGameInfo(CSPlayerMonopolyInfo res)
		{
		}

		// Token: 0x0600B1F9 RID: 45561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B1F9")]
		[Address(RVA = "0x1652AA8", Offset = "0x1652AA8", VA = "0x7BBBE52AA8")]
		public MonopolySettingDesc GetDiceGameSetting()
		{
			return null;
		}

		// Token: 0x0600B1FA RID: 45562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B1FA")]
		[Address(RVA = "0x1652AB0", Offset = "0x1652AB0", VA = "0x7BBBE52AB0")]
		public CSGetMonopolyConfigRes GetDiceGameConfig()
		{
			return null;
		}

		// Token: 0x0600B1FB RID: 45563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B1FB")]
		[Address(RVA = "0x1652AB8", Offset = "0x1652AB8", VA = "0x7BBBE52AB8")]
		public Dictionary<uint, MonopolyEventDesc> GetDiceGameEvents()
		{
			return null;
		}

		// Token: 0x0600B1FC RID: 45564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B1FC")]
		[Address(RVA = "0x1652AC0", Offset = "0x1652AC0", VA = "0x7BBBE52AC0")]
		public CSPlayerMonopolyInfo GetDiceGameInfo()
		{
			return null;
		}

		// Token: 0x0600B1FD RID: 45565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B1FD")]
		[Address(RVA = "0x1652AC8", Offset = "0x1652AC8", VA = "0x7BBBE52AC8")]
		public List<uint> GetFinishedPhaseRwdInfo()
		{
			return null;
		}

		// Token: 0x0600B1FE RID: 45566 RVA: 0x00032250 File Offset: 0x00030450
		[Token(Token = "0x600B1FE")]
		[Address(RVA = "0x1652AD0", Offset = "0x1652AD0", VA = "0x7BBBE52AD0")]
		public bool EnableRoll()
		{
			return default(bool);
		}

		// Token: 0x0600B1FF RID: 45567 RVA: 0x00032268 File Offset: 0x00030468
		[Token(Token = "0x600B1FF")]
		[Address(RVA = "0x1652BA4", Offset = "0x1652BA4", VA = "0x7BBBE52BA4")]
		public bool IsBonusRwdRoll()
		{
			return default(bool);
		}

		// Token: 0x0600B200 RID: 45568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B200")]
		[Address(RVA = "0x1652BAC", Offset = "0x1652BAC", VA = "0x7BBBE52BAC")]
		public MVPSettingDesc GetMVPSettingDesc()
		{
			return null;
		}

		// Token: 0x0600B201 RID: 45569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B201")]
		[Address(RVA = "0x1652BB4", Offset = "0x1652BB4", VA = "0x7BBBE52BB4")]
		public CSGetMVPSettingRes GetMvpSetting()
		{
			return null;
		}

		// Token: 0x0600B202 RID: 45570 RVA: 0x00032280 File Offset: 0x00030480
		[Token(Token = "0x600B202")]
		[Address(RVA = "0x1652BBC", Offset = "0x1652BBC", VA = "0x7BBBE52BBC")]
		public uint GetDiceGamePlayerPhase()
		{
			return 0U;
		}

		// Token: 0x0600B203 RID: 45571 RVA: 0x00032298 File Offset: 0x00030498
		[Token(Token = "0x600B203")]
		[Address(RVA = "0x1652C00", Offset = "0x1652C00", VA = "0x7BBBE52C00")]
		public bool IsDiceGamePlayerPhaseChangeRoll()
		{
			return default(bool);
		}

		// Token: 0x0600B204 RID: 45572 RVA: 0x000322B0 File Offset: 0x000304B0
		[Token(Token = "0x600B204")]
		[Address(RVA = "0x1652C08", Offset = "0x1652C08", VA = "0x7BBBE52C08")]
		private bool IsDiceGamePlayerMaxPhase()
		{
			return default(bool);
		}

		// Token: 0x0600B205 RID: 45573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B205")]
		[Address(RVA = "0x1652C34", Offset = "0x1652C34", VA = "0x7BBBE52C34")]
		public void InitTokenTipsDesc()
		{
		}

		// Token: 0x0600B206 RID: 45574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B206")]
		[Address(RVA = "0x1652DBC", Offset = "0x1652DBC", VA = "0x7BBBE52DBC")]
		public List<BigEventTokenTipsDesc> GetExchangeTokenTipsDescList()
		{
			return null;
		}

		// Token: 0x0600B207 RID: 45575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B207")]
		[Address(RVA = "0x1652DC4", Offset = "0x1652DC4", VA = "0x7BBBE52DC4")]
		public List<BigEventTokenTipsDesc> GetSugarTokenTipsDescList()
		{
			return null;
		}

		// Token: 0x0600B208 RID: 45576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B208")]
		[Address(RVA = "0x1652DCC", Offset = "0x1652DCC", VA = "0x7BBBE52DCC")]
		public void GetMVPPeakDayActivityDesc(out ClientActivityDesc activityDesc, out bool is_Expired)
		{
		}

		// Token: 0x0600B209 RID: 45577 RVA: 0x000322C8 File Offset: 0x000304C8
		[Token(Token = "0x600B209")]
		[Address(RVA = "0x1652EE4", Offset = "0x1652EE4", VA = "0x7BBBE52EE4")]
		public bool GetMVPPeakDayTipsShowOff()
		{
			return default(bool);
		}

		// Token: 0x0600B20A RID: 45578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B20A")]
		[Address(RVA = "0x1652FD4", Offset = "0x1652FD4", VA = "0x7BBBE52FD4", Slot = "8")]
		public override void Login(params object[] data)
		{
		}

		// Token: 0x0600B20B RID: 45579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B20B")]
		[Address(RVA = "0x1652FDC", Offset = "0x1652FDC", VA = "0x7BBBE52FDC", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600B20C RID: 45580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B20C")]
		[Address(RVA = "0x165311C", Offset = "0x165311C", VA = "0x7BBBE5311C")]
		public HttpRequest GetStoreRes(uint option = 0U)
		{
			return null;
		}

		// Token: 0x0600B20D RID: 45581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B20D")]
		[Address(RVA = "0x1653300", Offset = "0x1653300", VA = "0x7BBBE53300")]
		public List<LimitedEventStore> GetStoreList()
		{
			return null;
		}

		// Token: 0x0600B20E RID: 45582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B20E")]
		[Address(RVA = "0x1653308", Offset = "0x1653308", VA = "0x7BBBE53308")]
		public List<BigEventStoreCommodityDesc> GetStoreItemsList(uint id)
		{
			return null;
		}

		// Token: 0x0600B20F RID: 45583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B20F")]
		[Address(RVA = "0x1653474", Offset = "0x1653474", VA = "0x7BBBE53474")]
		public void RequesePurchase(BigEventStoreCommodityDesc desc, uint cnt = 1U)
		{
		}

		// Token: 0x0600B210 RID: 45584 RVA: 0x000322E0 File Offset: 0x000304E0
		[Token(Token = "0x600B210")]
		[Address(RVA = "0x165397C", Offset = "0x165397C", VA = "0x7BBBE5397C")]
		public int SortStoreItem(BigEventStoreCommodityDesc a, BigEventStoreCommodityDesc b)
		{
			return 0;
		}

		// Token: 0x0600B211 RID: 45585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B211")]
		[Address(RVA = "0x1653C20", Offset = "0x1653C20", VA = "0x7BBBE53C20")]
		public HttpRequest RequestMVPDesc(uint option = 0U)
		{
			return null;
		}

		// Token: 0x0600B212 RID: 45586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B212")]
		[Address(RVA = "0x1653E00", Offset = "0x1653E00", VA = "0x7BBBE53E00", Slot = "14")]
		public void OnProcessEventOpenInfo()
		{
		}

		// Token: 0x0600B213 RID: 45587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B213")]
		[Address(RVA = "0x1653E04", Offset = "0x1653E04", VA = "0x7BBBE53E04")]
		public ClientActivityDesc GetMVPSignInActivityDesc()
		{
			return null;
		}

		// Token: 0x0600B214 RID: 45588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B214")]
		[Address(RVA = "0x1653EAC", Offset = "0x1653EAC", VA = "0x7BBBE53EAC")]
		public void RequesMVPSignInReward()
		{
		}

		// Token: 0x0600B215 RID: 45589 RVA: 0x000322F8 File Offset: 0x000304F8
		[Token(Token = "0x600B215")]
		[Address(RVA = "0x16540EC", Offset = "0x16540EC", VA = "0x7BBBE540EC")]
		public bool GetMVPSignInTipsShowOff()
		{
			return default(bool);
		}

		// Token: 0x0600B216 RID: 45590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B216")]
		[Address(RVA = "0x16541BC", Offset = "0x16541BC", VA = "0x7BBBE541BC")]
		public UIModelMVP()
		{
		}

		// Token: 0x0600B217 RID: 45591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B217")]
		[Address(RVA = "0x1654314", Offset = "0x1654314", VA = "0x7BBBE54314")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146A2C", Offset = "0x1146A2C")]
		private void <RequestDiceGameConfig>b__32_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600B218 RID: 45592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B218")]
		[Address(RVA = "0x1654424", Offset = "0x1654424", VA = "0x7BBBE54424")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146A3C", Offset = "0x1146A3C")]
		private void <RequestDiceGameInfo>b__33_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600B219 RID: 45593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B219")]
		[Address(RVA = "0x165452C", Offset = "0x165452C", VA = "0x7BBBE5452C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146A4C", Offset = "0x1146A4C")]
		private void <RequestDiceGameRollDice>b__35_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600B21A RID: 45594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B21A")]
		[Address(RVA = "0x16546D8", Offset = "0x16546D8", VA = "0x7BBBE546D8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146A5C", Offset = "0x1146A5C")]
		private void <RequestDiceGameChooseEventBranch>b__37_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600B21B RID: 45595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B21B")]
		[Address(RVA = "0x1654834", Offset = "0x1654834", VA = "0x7BBBE54834")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146A6C", Offset = "0x1146A6C")]
		private void <RequestDiceGamePhaseRwdInfo>b__40_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600B21C RID: 45596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B21C")]
		[Address(RVA = "0x165495C", Offset = "0x165495C", VA = "0x7BBBE5495C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146A7C", Offset = "0x1146A7C")]
		private void <InitTokenTipsDesc>b__55_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600B21D RID: 45597 RVA: 0x00032310 File Offset: 0x00030510
		[Token(Token = "0x600B21D")]
		[Address(RVA = "0x1654AE8", Offset = "0x1654AE8", VA = "0x7BBBE54AE8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146A8C", Offset = "0x1146A8C")]
		private bool <InitTokenTipsDesc>b__55_1(BigEventTokenTipsDesc x)
		{
			return default(bool);
		}

		// Token: 0x0600B21E RID: 45598 RVA: 0x00032328 File Offset: 0x00030528
		[Token(Token = "0x600B21E")]
		[Address(RVA = "0x1654B34", Offset = "0x1654B34", VA = "0x7BBBE54B34")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146A9C", Offset = "0x1146A9C")]
		private bool <InitTokenTipsDesc>b__55_2(BigEventTokenTipsDesc x)
		{
			return default(bool);
		}

		// Token: 0x0600B21F RID: 45599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B21F")]
		[Address(RVA = "0x1654B80", Offset = "0x1654B80", VA = "0x7BBBE54B80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146AAC", Offset = "0x1146AAC")]
		private void <GetStoreRes>b__62_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600B220 RID: 45600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B220")]
		[Address(RVA = "0x1654EB4", Offset = "0x1654EB4", VA = "0x7BBBE54EB4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146ABC", Offset = "0x1146ABC")]
		private void <RequestMVPDesc>b__67_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600B221 RID: 45601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B221")]
		[Address(RVA = "0x1655038", Offset = "0x1655038", VA = "0x7BBBE55038")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146ACC", Offset = "0x1146ACC")]
		private void <RequesMVPSignInReward>b__70_0(HttpErrorCode errorCode, object obj)
		{
		}

		// Token: 0x0400B4F8 RID: 46328
		[Token(Token = "0x400B4F8")]
		public const uint PropID_DiceGameChooseBranchResult = 16U;

		// Token: 0x0400B4F9 RID: 46329
		[Token(Token = "0x400B4F9")]
		public const uint PropID_ClaimedDiceGamePhaseReward = 32U;

		// Token: 0x0400B4FA RID: 46330
		[Token(Token = "0x400B4FA")]
		public const uint PropID_UpdateDiceGamePhaseRewardInfo = 64U;

		// Token: 0x0400B4FB RID: 46331
		[Token(Token = "0x400B4FB")]
		public const uint PropID_UpdateMVPInfo = 2U;

		// Token: 0x0400B4FC RID: 46332
		[Token(Token = "0x400B4FC")]
		public const uint PropID_PurchaseSuccess = 4U;

		// Token: 0x0400B4FD RID: 46333
		[Token(Token = "0x400B4FD")]
		public const uint PropID_StoreItemsRefresh = 8U;

		// Token: 0x0400B4FE RID: 46334
		[Token(Token = "0x400B4FE")]
		public const uint PropID_GetMVPSignInReward = 128U;

		// Token: 0x0400B4FF RID: 46335
		[Token(Token = "0x400B4FF")]
		public const uint PropID_FetchDiceGameConfig = 256U;

		// Token: 0x0400B500 RID: 46336
		[Token(Token = "0x400B500")]
		public const uint PropID_FetchDiceGameInfo = 512U;

		// Token: 0x0400B501 RID: 46337
		[Token(Token = "0x400B501")]
		public const uint PropID_DiceGameRollDiceResult = 1024U;

		// Token: 0x0400B502 RID: 46338
		[Token(Token = "0x400B502")]
		public const uint PropID_GetMVPSignInRewardFailed = 2048U;

		// Token: 0x0400B503 RID: 46339
		[Token(Token = "0x400B503")]
		public const string MVPLOBBYTIP = "MVPLobbyTip";

		// Token: 0x0400B504 RID: 46340
		[Token(Token = "0x400B504")]
		public const string SignInTimes = "SignInTimes";

		// Token: 0x0400B505 RID: 46341
		[Token(Token = "0x400B505")]
		public const string GOTOWEBTIP = "GoWebTipKeyMVP";

		// Token: 0x0400B506 RID: 46342
		[Token(Token = "0x400B506")]
		public const string GOTOGACHATIP = "GoGachaTipKeyMVP";

		// Token: 0x0400B507 RID: 46343
		[Token(Token = "0x400B507")]
		[FieldOffset(Offset = "0x18")]
		private uint m_EvenID;

		// Token: 0x0400B508 RID: 46344
		[Token(Token = "0x400B508")]
		[FieldOffset(Offset = "0x20")]
		private MVPSettingDesc m_MVPSettingDesc;

		// Token: 0x0400B509 RID: 46345
		[Token(Token = "0x400B509")]
		[FieldOffset(Offset = "0x28")]
		private CSGetMVPSettingRes m_MVPSetting;

		// Token: 0x0400B50A RID: 46346
		[Token(Token = "0x400B50A")]
		[FieldOffset(Offset = "0x30")]
		private List<LimitedEventStore> m_StoreList;

		// Token: 0x0400B50B RID: 46347
		[Token(Token = "0x400B50B")]
		[FieldOffset(Offset = "0x38")]
		public bool m_PurchaseaitingForResponse;

		// Token: 0x0400B50C RID: 46348
		[Token(Token = "0x400B50C")]
		[FieldOffset(Offset = "0x40")]
		private List<BigEventTokenTipsDesc> m_Token_Exchange;

		// Token: 0x0400B50D RID: 46349
		[Token(Token = "0x400B50D")]
		[FieldOffset(Offset = "0x48")]
		private List<BigEventTokenTipsDesc> m_Token_Sugar;

		// Token: 0x0400B50E RID: 46350
		[Token(Token = "0x400B50E")]
		[FieldOffset(Offset = "0x50")]
		public Dictionary<uint, bool> StoreTipsOnOff;

		// Token: 0x0400B50F RID: 46351
		[Token(Token = "0x400B50F")]
		[FieldOffset(Offset = "0x58")]
		private CSGetMonopolyConfigRes m_MonopolyConfig;

		// Token: 0x0400B510 RID: 46352
		[Token(Token = "0x400B510")]
		[FieldOffset(Offset = "0x60")]
		private MonopolySettingDesc m_MonopolySetting;

		// Token: 0x0400B511 RID: 46353
		[Token(Token = "0x400B511")]
		[FieldOffset(Offset = "0x68")]
		private CSPlayerMonopolyInfo m_MonopolyPlayerInfo;

		// Token: 0x0400B512 RID: 46354
		[Token(Token = "0x400B512")]
		[FieldOffset(Offset = "0x70")]
		private Dictionary<uint, MonopolyEventDesc> m_MonopolyEventMap;

		// Token: 0x0400B513 RID: 46355
		[Token(Token = "0x400B513")]
		[FieldOffset(Offset = "0x78")]
		private List<uint> m_FinishedPhaseRwdIds;

		// Token: 0x0400B514 RID: 46356
		[Token(Token = "0x400B514")]
		[FieldOffset(Offset = "0x80")]
		private bool m_IsBonusRwdRoll;

		// Token: 0x0400B515 RID: 46357
		[Token(Token = "0x400B515")]
		[FieldOffset(Offset = "0x81")]
		private bool m_IsDiceGamePlayerPhaseChangeRoll;

		// Token: 0x0400B516 RID: 46358
		[Token(Token = "0x400B516")]
		[FieldOffset(Offset = "0x88")]
		private CSMonopolyRollReq m_PendingRollReq;

		// Token: 0x0400B517 RID: 46359
		[Token(Token = "0x400B517")]
		[FieldOffset(Offset = "0x90")]
		private CSMonopolyEventChooseReq m_PendingChooseEventBranchReq;

		// Token: 0x0400B518 RID: 46360
		[Token(Token = "0x400B518")]
		[FieldOffset(Offset = "0x98")]
		private CSClaimMVPProcessRewardsReq m_PendingClaimPhaseRewardReq;

		// Token: 0x02001F71 RID: 8049
		[Token(Token = "0x2001F71")]
		public class NotifyArgsPurchase
		{
			// Token: 0x0600B222 RID: 45602 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B222")]
			[Address(RVA = "0x1656450", Offset = "0x1656450", VA = "0x7BBBE56450")]
			public NotifyArgsPurchase()
			{
			}

			// Token: 0x0400B519 RID: 46361
			[Token(Token = "0x400B519")]
			[FieldOffset(Offset = "0x10")]
			public uint skuID;
		}

		// Token: 0x02001F72 RID: 8050
		[Token(Token = "0x2001F72")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD294", Offset = "0x10FD294")]
		private sealed class <>c__DisplayClass39_0
		{
			// Token: 0x0600B223 RID: 45603 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B223")]
			[Address(RVA = "0x1652640", Offset = "0x1652640", VA = "0x7BBBE52640")]
			public <>c__DisplayClass39_0()
			{
			}

			// Token: 0x0600B224 RID: 45604 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B224")]
			[Address(RVA = "0x1655498", Offset = "0x1655498", VA = "0x7BBBE55498")]
			internal void <RequestClaimPhaseReward>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B51A RID: 46362
			[Token(Token = "0x400B51A")]
			[FieldOffset(Offset = "0x10")]
			public UIModelMVP <>4__this;

			// Token: 0x0400B51B RID: 46363
			[Token(Token = "0x400B51B")]
			[FieldOffset(Offset = "0x18")]
			public uint processId;
		}

		// Token: 0x02001F73 RID: 8051
		[Token(Token = "0x2001F73")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD2A4", Offset = "0x10FD2A4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600B226 RID: 45606 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B226")]
			[Address(RVA = "0x16553CC", Offset = "0x16553CC", VA = "0x7BBBE553CC")]
			public <>c()
			{
			}

			// Token: 0x0600B227 RID: 45607 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B227")]
			[Address(RVA = "0x16553D4", Offset = "0x16553D4", VA = "0x7BBBE553D4")]
			internal CommonRewardItemInfo <RequestClaimPhaseReward>b__39_1(BaseItemInfo item)
			{
				return null;
			}

			// Token: 0x0600B228 RID: 45608 RVA: 0x00032340 File Offset: 0x00030540
			[Token(Token = "0x600B228")]
			[Address(RVA = "0x16553E0", Offset = "0x16553E0", VA = "0x7BBBE553E0")]
			internal int <ProcessDiceGameConfig>b__41_0(MonopolyNodeDesc a, MonopolyNodeDesc b)
			{
				return 0;
			}

			// Token: 0x0600B229 RID: 45609 RVA: 0x00032358 File Offset: 0x00030558
			[Token(Token = "0x600B229")]
			[Address(RVA = "0x1655424", Offset = "0x1655424", VA = "0x7BBBE55424")]
			internal int <GetStoreRes>b__62_1(LimitedEventStore a, LimitedEventStore b)
			{
				return 0;
			}

			// Token: 0x0600B22A RID: 45610 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B22A")]
			[Address(RVA = "0x165548C", Offset = "0x165548C", VA = "0x7BBBE5548C")]
			internal CommonRewardItemInfo <RequesMVPSignInReward>b__70_1(BaseItemInfo item)
			{
				return null;
			}

			// Token: 0x0400B51C RID: 46364
			[Token(Token = "0x400B51C")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIModelMVP.<>c <>9;

			// Token: 0x0400B51D RID: 46365
			[Token(Token = "0x400B51D")]
			[FieldOffset(Offset = "0x8")]
			public static Converter<BaseItemInfo, CommonRewardItemInfo> <>9__39_1;

			// Token: 0x0400B51E RID: 46366
			[Token(Token = "0x400B51E")]
			[FieldOffset(Offset = "0x10")]
			public static Comparison<MonopolyNodeDesc> <>9__41_0;

			// Token: 0x0400B51F RID: 46367
			[Token(Token = "0x400B51F")]
			[FieldOffset(Offset = "0x18")]
			public static Comparison<LimitedEventStore> <>9__62_1;

			// Token: 0x0400B520 RID: 46368
			[Token(Token = "0x400B520")]
			[FieldOffset(Offset = "0x20")]
			public static Converter<BaseItemInfo, CommonRewardItemInfo> <>9__70_1;
		}

		// Token: 0x02001F74 RID: 8052
		[Token(Token = "0x2001F74")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD2B4", Offset = "0x10FD2B4")]
		private sealed class <>c__DisplayClass64_0
		{
			// Token: 0x0600B22B RID: 45611 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B22B")]
			[Address(RVA = "0x165346C", Offset = "0x165346C", VA = "0x7BBBE5346C")]
			public <>c__DisplayClass64_0()
			{
			}

			// Token: 0x0600B22C RID: 45612 RVA: 0x00032370 File Offset: 0x00030570
			[Token(Token = "0x600B22C")]
			[Address(RVA = "0x16557C8", Offset = "0x16557C8", VA = "0x7BBBE557C8")]
			internal bool <GetStoreItemsList>b__0(LimitedEventStore store)
			{
				return default(bool);
			}

			// Token: 0x0400B521 RID: 46369
			[Token(Token = "0x400B521")]
			[FieldOffset(Offset = "0x10")]
			public uint id;
		}

		// Token: 0x02001F75 RID: 8053
		[Token(Token = "0x2001F75")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD2C4", Offset = "0x10FD2C4")]
		private sealed class <>c__DisplayClass65_0
		{
			// Token: 0x0600B22D RID: 45613 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B22D")]
			[Address(RVA = "0x1653974", Offset = "0x1653974", VA = "0x7BBBE53974")]
			public <>c__DisplayClass65_0()
			{
			}

			// Token: 0x0600B22E RID: 45614 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B22E")]
			[Address(RVA = "0x1655814", Offset = "0x1655814", VA = "0x7BBBE55814")]
			internal void <RequesePurchase>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0600B22F RID: 45615 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B22F")]
			[Address(RVA = "0x1656458", Offset = "0x1656458", VA = "0x7BBBE56458")]
			internal void <RequesePurchase>b__1()
			{
			}

			// Token: 0x0400B522 RID: 46370
			[Token(Token = "0x400B522")]
			[FieldOffset(Offset = "0x10")]
			public UIModelMVP <>4__this;

			// Token: 0x0400B523 RID: 46371
			[Token(Token = "0x400B523")]
			[FieldOffset(Offset = "0x18")]
			public BigEventStoreCommodityDesc desc;

			// Token: 0x0400B524 RID: 46372
			[Token(Token = "0x400B524")]
			[FieldOffset(Offset = "0x20")]
			public uint cnt;

			// Token: 0x0400B525 RID: 46373
			[Token(Token = "0x400B525")]
			[FieldOffset(Offset = "0x28")]
			public Action <>9__1;
		}
	}
}
