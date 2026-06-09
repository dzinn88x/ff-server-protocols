using System;
using COW;
using GCommon;
using Il2CppDummyDll;
using proto;

// Token: 0x02000104 RID: 260
[Token(Token = "0x2000104")]
public class UIClanLevelUpController : UIPopupWindowController
{
	// Token: 0x060004BD RID: 1213 RVA: 0x00002D00 File Offset: 0x00000F00
	[Token(Token = "0x60004BD")]
	[Address(RVA = "0x1C9DD14", Offset = "0x1C9DD14", VA = "0x7BBC49DD14")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	// Token: 0x060004BE RID: 1214 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004BE")]
	[Address(RVA = "0x1C9DD64", Offset = "0x1C9DD64", VA = "0x7BBC49DD64", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	// Token: 0x060004BF RID: 1215 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004BF")]
	[Address(RVA = "0x1C9DE48", Offset = "0x1C9DE48", VA = "0x7BBC49DE48")]
	public void SetLevelData(uint before, uint after, AwardData awardList)
	{
	}

	// Token: 0x060004C0 RID: 1216 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004C0")]
	[Address(RVA = "0x1C9E1D8", Offset = "0x1C9E1D8", VA = "0x7BBC49E1D8")]
	private void OnOKClick()
	{
	}

	// Token: 0x060004C1 RID: 1217 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004C1")]
	[Address(RVA = "0x1C9E1E0", Offset = "0x1C9E1E0", VA = "0x7BBC49E1E0")]
	public UIClanLevelUpController()
	{
	}

	// Token: 0x0400041C RID: 1052
	[Token(Token = "0x400041C")]
	[FieldOffset(Offset = "0x98")]
	private UIClanLevelUpViewExt m_View;
}
