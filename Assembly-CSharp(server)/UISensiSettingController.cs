using System;
using COW;
using GCommon;
using Il2CppDummyDll;

// Token: 0x020000F8 RID: 248
[Token(Token = "0x20000F8")]
public class UISensiSettingController : UISettingContentBase
{
	// Token: 0x0600048F RID: 1167 RVA: 0x00002C28 File Offset: 0x00000E28
	[Token(Token = "0x600048F")]
	[Address(RVA = "0x1FCD28C", Offset = "0x1FCD28C", VA = "0x7BBC7CD28C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	// Token: 0x06000490 RID: 1168 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000490")]
	[Address(RVA = "0x1FCD2DC", Offset = "0x1FCD2DC", VA = "0x7BBC7CD2DC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	// Token: 0x06000491 RID: 1169 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000491")]
	[Address(RVA = "0x1FCD8E8", Offset = "0x1FCD8E8", VA = "0x7BBC7CD8E8")]
	private void OnQuitButtonClick()
	{
	}

	// Token: 0x06000492 RID: 1170 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000492")]
	[Address(RVA = "0x1FCD984", Offset = "0x1FCD984", VA = "0x7BBC7CD984")]
	private void OnSensitivyResetBtnClick()
	{
	}

	// Token: 0x06000493 RID: 1171 RVA: 0x00002C40 File Offset: 0x00000E40
	[Token(Token = "0x6000493")]
	[Address(RVA = "0x1FCDCA8", Offset = "0x1FCDCA8", VA = "0x7BBC7CDCA8")]
	private float GetDefaultSensitivy(int type)
	{
		return 0f;
	}

	// Token: 0x06000494 RID: 1172 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000494")]
	[Address(RVA = "0x1FCDD10", Offset = "0x1FCDD10", VA = "0x7BBC7CDD10")]
	public UISensiSettingController()
	{
	}

	// Token: 0x06000495 RID: 1173 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000495")]
	[Address(RVA = "0x1FCDD18", Offset = "0x1FCDD18", VA = "0x7BBC7CDD18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1132D2C", Offset = "0x1132D2C")]
	private void <OnSensitivyResetBtnClick>b__4_0()
	{
	}

	// Token: 0x040003F2 RID: 1010
	[Token(Token = "0x40003F2")]
	[FieldOffset(Offset = "0x60")]
	private UISensiSettingView m_View;
}
