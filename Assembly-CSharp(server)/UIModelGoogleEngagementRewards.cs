using System;
using System.Collections.Generic;
using COW;
using GCommon;
using GCommon.GoogleEngagementRewards;
using Il2CppDummyDll;
using proto;

// Token: 0x02000140 RID: 320
[Token(Token = "0x2000140")]
public class UIModelGoogleEngagementRewards : UIBaseModel
{
	// Token: 0x060005F5 RID: 1525 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005F5")]
	[Address(RVA = "0x1CAC5A0", Offset = "0x1CAC5A0", VA = "0x7BBC4AC5A0")]
	public void LogVerbose(string content)
	{
	}

	// Token: 0x060005F6 RID: 1526 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005F6")]
	[Address(RVA = "0x1CAC640", Offset = "0x1CAC640", VA = "0x7BBC4AC640")]
	public string ActionToString(UIModelGoogleEngagementRewards.Action action)
	{
		return null;
	}

	// Token: 0x060005F7 RID: 1527 RVA: 0x00003120 File Offset: 0x00001320
	[Token(Token = "0x60005F7")]
	[Address(RVA = "0x1CAC7AC", Offset = "0x1CAC7AC", VA = "0x7BBC4AC7AC", Slot = "6")]
	public override uint GetModelType()
	{
		return 0U;
	}

	// Token: 0x060005F8 RID: 1528 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005F8")]
	[Address(RVA = "0x1CAC7B4", Offset = "0x1CAC7B4", VA = "0x7BBC4AC7B4", Slot = "8")]
	public override void Login(params object[] data)
	{
	}

	// Token: 0x060005F9 RID: 1529 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005F9")]
	[Address(RVA = "0x1CAC7BC", Offset = "0x1CAC7BC", VA = "0x7BBC4AC7BC", Slot = "7")]
	public override void LoginOffline()
	{
	}

	// Token: 0x060005FA RID: 1530 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005FA")]
	[Address(RVA = "0x1CAC7C4", Offset = "0x1CAC7C4", VA = "0x7BBC4AC7C4", Slot = "9")]
	public override void Logout(params object[] data)
	{
	}

	// Token: 0x060005FB RID: 1531 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005FB")]
	[Address(RVA = "0x1CAC86C", Offset = "0x1CAC86C", VA = "0x7BBC4AC86C")]
	private void ReloadData()
	{
	}

	// Token: 0x060005FC RID: 1532 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005FC")]
	[Address(RVA = "0x1CACA5C", Offset = "0x1CACA5C", VA = "0x7BBC4ACA5C")]
	private void NotifyIfHasAllData()
	{
	}

	// Token: 0x060005FD RID: 1533 RVA: 0x00003138 File Offset: 0x00001338
	[Token(Token = "0x60005FD")]
	[Address(RVA = "0x1CACA60", Offset = "0x1CACA60", VA = "0x7BBC4ACA60")]
	public bool ShouldShow()
	{
		return default(bool);
	}

	// Token: 0x060005FE RID: 1534 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005FE")]
	[Address(RVA = "0x1CACB48", Offset = "0x1CACB48", VA = "0x7BBC4ACB48")]
	public Dictionary<UIModelGoogleEngagementRewards.Action, UIModelGoogleEngagementRewards.GERDatum> GetEligibleActions()
	{
		return null;
	}

	// Token: 0x060005FF RID: 1535 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005FF")]
	[Address(RVA = "0x1CACD58", Offset = "0x1CACD58", VA = "0x7BBC4ACD58")]
	public Dictionary<UIModelGoogleEngagementRewards.Action, UIModelGoogleEngagementRewards.GERDatum> GetTriggerableActions()
	{
		return null;
	}

	// Token: 0x06000600 RID: 1536 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000600")]
	[Address(RVA = "0x1CACC10", Offset = "0x1CACC10", VA = "0x7BBC4ACC10")]
	public Dictionary<UIModelGoogleEngagementRewards.Action, UIModelGoogleEngagementRewards.GERDatum> GetTriggeredActions()
	{
		return null;
	}

	// Token: 0x06000601 RID: 1537 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000601")]
	[Address(RVA = "0x1CAD080", Offset = "0x1CAD080", VA = "0x7BBC4AD080")]
	public void SetData_CFG(CSGetGoogleRewardsDescRes res)
	{
	}

	// Token: 0x17000052 RID: 82
	// (get) Token: 0x06000602 RID: 1538 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000052")]
	private Dictionary<UIModelGoogleEngagementRewards.Action, UIModelGoogleEngagementRewards.GERDatum> CurrentRegionData_CFG
	{
		[Token(Token = "0x6000602")]
		[Address(RVA = "0x1CACE30", Offset = "0x1CACE30", VA = "0x7BBC4ACE30")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000603 RID: 1539 RVA: 0x00003150 File Offset: 0x00001350
	[Token(Token = "0x6000603")]
	[Address(RVA = "0x1CAD818", Offset = "0x1CAD818", VA = "0x7BBC4AD818")]
	public bool IsEligible_CFG(UIModelGoogleEngagementRewards.Action action)
	{
		return default(bool);
	}

	// Token: 0x06000604 RID: 1540 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000604")]
	[Address(RVA = "0x1CACCF4", Offset = "0x1CACCF4", VA = "0x7BBC4ACCF4")]
	private Dictionary<UIModelGoogleEngagementRewards.Action, UIModelGoogleEngagementRewards.GERDatum> GetEligibleActions_CFG()
	{
		return null;
	}

	// Token: 0x06000605 RID: 1541 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000605")]
	[Address(RVA = "0x1CAD878", Offset = "0x1CAD878", VA = "0x7BBC4AD878")]
	public void UpdateData_ACT()
	{
	}

	// Token: 0x06000606 RID: 1542 RVA: 0x00003168 File Offset: 0x00001368
	[Token(Token = "0x6000606")]
	[Address(RVA = "0x1CAD8F4", Offset = "0x1CAD8F4", VA = "0x7BBC4AD8F4")]
	public bool IsEligible_ACT(UIModelGoogleEngagementRewards.Action action)
	{
		return default(bool);
	}

	// Token: 0x06000607 RID: 1543 RVA: 0x00003180 File Offset: 0x00001380
	[Token(Token = "0x6000607")]
	[Address(RVA = "0x1CADAF0", Offset = "0x1CADAF0", VA = "0x7BBC4ADAF0")]
	public bool CanTrigger_ACT(UIModelGoogleEngagementRewards.Action action)
	{
		return default(bool);
	}

	// Token: 0x06000608 RID: 1544 RVA: 0x00003198 File Offset: 0x00001398
	[Token(Token = "0x6000608")]
	[Address(RVA = "0x1CADB80", Offset = "0x1CADB80", VA = "0x7BBC4ADB80")]
	public bool CanRedeem_ACT(UIModelGoogleEngagementRewards.Action action)
	{
		return default(bool);
	}

	// Token: 0x06000609 RID: 1545 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000609")]
	[Address(RVA = "0x1CADB98", Offset = "0x1CADB98", VA = "0x7BBC4ADB98")]
	public Dictionary<UIModelGoogleEngagementRewards.Action, EEventType> GetTriggerableActions_ACT()
	{
		return null;
	}

	// Token: 0x0600060A RID: 1546 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600060A")]
	[Address(RVA = "0x1CADBFC", Offset = "0x1CADBFC", VA = "0x7BBC4ADBFC")]
	public Dictionary<UIModelGoogleEngagementRewards.Action, EEventType> GetRedeemableActions_ACT()
	{
		return null;
	}

	// Token: 0x0600060B RID: 1547 RVA: 0x000031B0 File Offset: 0x000013B0
	[Token(Token = "0x600060B")]
	[Address(RVA = "0x1CADC60", Offset = "0x1CADC60", VA = "0x7BBC4ADC60")]
	public bool HasStoredGoogleAccount()
	{
		return default(bool);
	}

	// Token: 0x0600060C RID: 1548 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600060C")]
	[Address(RVA = "0x1CADC70", Offset = "0x1CADC70", VA = "0x7BBC4ADC70")]
	public string GetStoredGoogleAccount()
	{
		return null;
	}

	// Token: 0x0600060D RID: 1549 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600060D")]
	[Address(RVA = "0x1CADC78", Offset = "0x1CADC78", VA = "0x7BBC4ADC78")]
	public void ClearStoredGoogleAccount()
	{
	}

	// Token: 0x0600060E RID: 1550 RVA: 0x000031C8 File Offset: 0x000013C8
	[Token(Token = "0x600060E")]
	[Address(RVA = "0x1CADC68", Offset = "0x1CADC68", VA = "0x7BBC4ADC68")]
	public bool HasAccessToGoogleAccount()
	{
		return default(bool);
	}

	// Token: 0x0600060F RID: 1551 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600060F")]
	[Address(RVA = "0x1CADCF0", Offset = "0x1CADCF0", VA = "0x7BBC4ADCF0")]
	public void RequestAccessToGoogleAccount(Action<bool> callback)
	{
	}

	// Token: 0x06000610 RID: 1552 RVA: 0x000031E0 File Offset: 0x000013E0
	[Token(Token = "0x6000610")]
	[Address(RVA = "0x1CADCF4", Offset = "0x1CADCF4", VA = "0x7BBC4ADCF4")]
	public bool IsGoogleSignedIn()
	{
		return default(bool);
	}

	// Token: 0x06000611 RID: 1553 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000611")]
	[Address(RVA = "0x1CADD68", Offset = "0x1CADD68", VA = "0x7BBC4ADD68")]
	public void GoogleSignIn()
	{
	}

	// Token: 0x06000612 RID: 1554 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000612")]
	[Address(RVA = "0x1CADDD4", Offset = "0x1CADDD4", VA = "0x7BBC4ADDD4")]
	public void OnGoogleSignIn()
	{
	}

	// Token: 0x06000613 RID: 1555 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000613")]
	[Address(RVA = "0x1CADF1C", Offset = "0x1CADF1C", VA = "0x7BBC4ADF1C")]
	public void ForceNativeGoogleSignIn()
	{
	}

	// Token: 0x06000614 RID: 1556 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000614")]
	[Address(RVA = "0x1CADF20", Offset = "0x1CADF20", VA = "0x7BBC4ADF20")]
	public string[] GetGoogleAccountsOptions()
	{
		return null;
	}

	// Token: 0x06000615 RID: 1557 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000615")]
	[Address(RVA = "0x1CADF28", Offset = "0x1CADF28", VA = "0x7BBC4ADF28")]
	public void SelectGoogleAccount(string account)
	{
	}

	// Token: 0x06000616 RID: 1558 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000616")]
	[Address(RVA = "0x1CAE014", Offset = "0x1CAE014", VA = "0x7BBC4AE014")]
	public void RefreshGoogleAccountToken(string accountName)
	{
	}

	// Token: 0x06000617 RID: 1559 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000617")]
	[Address(RVA = "0x1CAE070", Offset = "0x1CAE070", VA = "0x7BBC4AE070")]
	public void OnRefreshGoogleAccountToken(string accountName)
	{
	}

	// Token: 0x06000618 RID: 1560 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000618")]
	[Address(RVA = "0x1CAE1C8", Offset = "0x1CAE1C8", VA = "0x7BBC4AE1C8")]
	public void OnRefreshGoogleAccountTokenError(GoogleEngagementRewards.RefreshTokenError error, string message)
	{
	}

	// Token: 0x06000619 RID: 1561 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000619")]
	[Address(RVA = "0x1CAE2B4", Offset = "0x1CAE2B4", VA = "0x7BBC4AE2B4")]
	private void _GoogleRevoke()
	{
	}

	// Token: 0x0600061A RID: 1562 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600061A")]
	[Address(RVA = "0x1CAE3D4", Offset = "0x1CAE3D4", VA = "0x7BBC4AE3D4")]
	public void OnGoogleRevoke()
	{
	}

	// Token: 0x0600061B RID: 1563 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600061B")]
	[Address(RVA = "0x1CAE4A8", Offset = "0x1CAE4A8", VA = "0x7BBC4AE4A8")]
	public void GoogleRevokeAndSignIn()
	{
	}

	// Token: 0x0600061C RID: 1564 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600061C")]
	[Address(RVA = "0x1CAE4AC", Offset = "0x1CAE4AC", VA = "0x7BBC4AE4AC")]
	private void InitSDK()
	{
	}

	// Token: 0x0600061D RID: 1565 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600061D")]
	[Address(RVA = "0x1CAE528", Offset = "0x1CAE528", VA = "0x7BBC4AE528")]
	private void FetchData_SDK()
	{
	}

	// Token: 0x0600061E RID: 1566 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600061E")]
	[Address(RVA = "0x1CADCEC", Offset = "0x1CADCEC", VA = "0x7BBC4ADCEC")]
	private void _FetchData_SDK()
	{
	}

	// Token: 0x0600061F RID: 1567 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600061F")]
	[Address(RVA = "0x1CAE594", Offset = "0x1CAE594", VA = "0x7BBC4AE594")]
	public void OnGetAvailablePromotions_SDK(GoogleEngagementRewards.PromotionsResult result)
	{
	}

	// Token: 0x06000620 RID: 1568 RVA: 0x000031F8 File Offset: 0x000013F8
	[Token(Token = "0x6000620")]
	[Address(RVA = "0x1CAE89C", Offset = "0x1CAE89C", VA = "0x7BBC4AE89C")]
	public bool IsEligible_SDK(UIModelGoogleEngagementRewards.Action action)
	{
		return default(bool);
	}

	// Token: 0x06000621 RID: 1569 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000621")]
	[Address(RVA = "0x1CAE8FC", Offset = "0x1CAE8FC", VA = "0x7BBC4AE8FC")]
	public void OnRedeemPromotionSuccess(GoogleEngagementRewards.Reward reward)
	{
	}

	// Token: 0x06000622 RID: 1570 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000622")]
	[Address(RVA = "0x1CAECF0", Offset = "0x1CAECF0", VA = "0x7BBC4AECF0")]
	public void OnRedeemPromotionFailure(GoogleEngagementRewards.ThrowableJSON throwable)
	{
	}

	// Token: 0x17000053 RID: 83
	// (get) Token: 0x06000623 RID: 1571 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000053")]
	public string Action_PurchaseElitePass
	{
		[Token(Token = "0x6000623")]
		[Address(RVA = "0x1CAC6A8", Offset = "0x1CAC6A8", VA = "0x7BBC4AC6A8")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000624 RID: 1572 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000624")]
	[Address(RVA = "0x1CAEDF4", Offset = "0x1CAEDF4", VA = "0x7BBC4AEDF4")]
	public void OnElitePassPurchased()
	{
	}

	// Token: 0x06000625 RID: 1573 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000625")]
	[Address(RVA = "0x1CAEE3C", Offset = "0x1CAEE3C", VA = "0x7BBC4AEE3C")]
	public void TriggerAction(UIModelGoogleEngagementRewards.Action action)
	{
	}

	// Token: 0x06000626 RID: 1574 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000626")]
	[Address(RVA = "0x1CAEE40", Offset = "0x1CAEE40", VA = "0x7BBC4AEE40")]
	private Dictionary<UIModelGoogleEngagementRewards.Action, EEventType> GetRedeemableActions()
	{
		return null;
	}

	// Token: 0x06000627 RID: 1575 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000627")]
	[Address(RVA = "0x1CAECEC", Offset = "0x1CAECEC", VA = "0x7BBC4AECEC")]
	private void ProcessRedeemablePromotions()
	{
	}

	// Token: 0x06000628 RID: 1576 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000628")]
	[Address(RVA = "0x1CAEF08", Offset = "0x1CAEF08", VA = "0x7BBC4AEF08")]
	private void _RedeemPromotionForAction(UIModelGoogleEngagementRewards.Action action)
	{
	}

	// Token: 0x06000629 RID: 1577 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000629")]
	[Address(RVA = "0x1CAEF0C", Offset = "0x1CAEF0C", VA = "0x7BBC4AEF0C")]
	public UIModelGoogleEngagementRewards()
	{
	}

	// Token: 0x0600062A RID: 1578 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600062A")]
	[Address(RVA = "0x1CAF014", Offset = "0x1CAF014", VA = "0x7BBC4AF014")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1132FE4", Offset = "0x1132FE4")]
	private void <ReloadData>b__18_0(HttpErrorCode code, object obj)
	{
	}

	// Token: 0x0600062B RID: 1579 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600062B")]
	[Address(RVA = "0x1CAF100", Offset = "0x1CAF100", VA = "0x7BBC4AF100")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1132FF4", Offset = "0x1132FF4")]
	private void <TriggerAction>b__66_0(HttpErrorCode errCode, object obj)
	{
	}

	// Token: 0x04000529 RID: 1321
	[Token(Token = "0x4000529")]
	public const uint PropID_GoogleSignIn = 2U;

	// Token: 0x0400052A RID: 1322
	[Token(Token = "0x400052A")]
	public const uint PropID_GoogleRevoke = 8U;

	// Token: 0x0400052B RID: 1323
	[Token(Token = "0x400052B")]
	public const uint PropID_LoadData = 32U;

	// Token: 0x0400052C RID: 1324
	[Token(Token = "0x400052C")]
	public const uint PropID_SelectedGoogleAccount = 64U;

	// Token: 0x0400052D RID: 1325
	[Token(Token = "0x400052D")]
	public const uint PropID_RefreshGoogleAccountToken = 128U;

	// Token: 0x0400052E RID: 1326
	[Token(Token = "0x400052E")]
	[FieldOffset(Offset = "0x18")]
	private bool m_HasData_CFG;

	// Token: 0x0400052F RID: 1327
	[Token(Token = "0x400052F")]
	[FieldOffset(Offset = "0x19")]
	private bool m_HasData_ACT;

	// Token: 0x04000530 RID: 1328
	[Token(Token = "0x4000530")]
	[FieldOffset(Offset = "0x1A")]
	private bool m_HasData_SDK;

	// Token: 0x04000531 RID: 1329
	[Token(Token = "0x4000531")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<string, Dictionary<UIModelGoogleEngagementRewards.Action, UIModelGoogleEngagementRewards.GERDatum>> RegionActionData_CFG;

	// Token: 0x04000532 RID: 1330
	[Token(Token = "0x4000532")]
	private const string DEFAULT_REGION = "default";

	// Token: 0x04000533 RID: 1331
	[Token(Token = "0x4000533")]
	[FieldOffset(Offset = "0x28")]
	private readonly Dictionary<UIModelGoogleEngagementRewards.Action, EEventType> m_ActionToActivityType;

	// Token: 0x04000534 RID: 1332
	[Token(Token = "0x4000534")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<string, GoogleEngagementRewards.Promotion> ActionToPromotions_SDK;

	// Token: 0x02000141 RID: 321
	[Token(Token = "0x2000141")]
	public enum HasPaidCondition
	{
		// Token: 0x04000536 RID: 1334
		[Token(Token = "0x4000536")]
		All,
		// Token: 0x04000537 RID: 1335
		[Token(Token = "0x4000537")]
		Unpaid,
		// Token: 0x04000538 RID: 1336
		[Token(Token = "0x4000538")]
		Paid
	}

	// Token: 0x02000142 RID: 322
	[Token(Token = "0x2000142")]
	public enum HasEPCondition
	{
		// Token: 0x0400053A RID: 1338
		[Token(Token = "0x400053A")]
		All,
		// Token: 0x0400053B RID: 1339
		[Token(Token = "0x400053B")]
		No,
		// Token: 0x0400053C RID: 1340
		[Token(Token = "0x400053C")]
		Yes
	}

	// Token: 0x02000143 RID: 323
	[Token(Token = "0x2000143")]
	public class GERDatum
	{
		// Token: 0x0600062C RID: 1580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600062C")]
		[Address(RVA = "0x1FBE838", Offset = "0x1FBE838", VA = "0x7BBC7BE838")]
		public static UIModelGoogleEngagementRewards.GERDatum _(GoogleRewardsDesc desc)
		{
			return null;
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x00003210 File Offset: 0x00001410
		[Token(Token = "0x600062D")]
		[Address(RVA = "0x1FBE954", Offset = "0x1FBE954", VA = "0x7BBC7BE954")]
		public bool ShouldShowByHasPaid(bool hasPaid)
		{
			return default(bool);
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x00003228 File Offset: 0x00001428
		[Token(Token = "0x600062E")]
		[Address(RVA = "0x1FBE988", Offset = "0x1FBE988", VA = "0x7BBC7BE988")]
		public bool ShouldShowByHasEP(bool hasEP)
		{
			return default(bool);
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600062F")]
		[Address(RVA = "0x1FBE94C", Offset = "0x1FBE94C", VA = "0x7BBC7BE94C")]
		public GERDatum()
		{
		}

		// Token: 0x0400053D RID: 1341
		[Token(Token = "0x400053D")]
		[FieldOffset(Offset = "0x10")]
		public string Region;

		// Token: 0x0400053E RID: 1342
		[Token(Token = "0x400053E")]
		[FieldOffset(Offset = "0x18")]
		public UIModelGoogleEngagementRewards.Action Action;

		// Token: 0x0400053F RID: 1343
		[Token(Token = "0x400053F")]
		[FieldOffset(Offset = "0x1C")]
		public UIModelGoogleEngagementRewards.HasEPCondition EP;

		// Token: 0x04000540 RID: 1344
		[Token(Token = "0x4000540")]
		[FieldOffset(Offset = "0x20")]
		public UIModelGoogleEngagementRewards.HasPaidCondition Paid;

		// Token: 0x04000541 RID: 1345
		[Token(Token = "0x4000541")]
		[FieldOffset(Offset = "0x28")]
		public string TaskDescKey;

		// Token: 0x04000542 RID: 1346
		[Token(Token = "0x4000542")]
		[FieldOffset(Offset = "0x30")]
		public string RewardDescKey;
	}

	// Token: 0x02000144 RID: 324
	[Token(Token = "0x2000144")]
	public enum Action
	{
		// Token: 0x04000544 RID: 1348
		[Token(Token = "0x4000544")]
		None,
		// Token: 0x04000545 RID: 1349
		[Token(Token = "0x4000545")]
		PurchaseElitePass
	}
}
