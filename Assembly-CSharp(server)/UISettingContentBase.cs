using System;
using GCommon;
using Il2CppDummyDll;

// Token: 0x020000F9 RID: 249
[Token(Token = "0x20000F9")]
public class UISettingContentBase : UIBaseController
{
	// Token: 0x06000496 RID: 1174 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000496")]
	[Address(RVA = "0x1FCDF68", Offset = "0x1FCDF68", VA = "0x7BBC7CDF68", Slot = "28")]
	public virtual void SetInGameShow(bool isInGame)
	{
	}

	// Token: 0x06000497 RID: 1175 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000497")]
	[Address(RVA = "0x1FC42C8", Offset = "0x1FC42C8", VA = "0x7BBC7C42C8", Slot = "29")]
	protected virtual void InitSettingInfo()
	{
	}

	// Token: 0x06000498 RID: 1176 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000498")]
	[Address(RVA = "0x1FC1038", Offset = "0x1FC1038", VA = "0x7BBC7C1038", Slot = "30")]
	public virtual void RefreshContent()
	{
	}

	// Token: 0x06000499 RID: 1177 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000499")]
	[Address(RVA = "0x1FC3320", Offset = "0x1FC3320", VA = "0x7BBC7C3320")]
	public UISettingContentBase()
	{
	}

	// Token: 0x040003F3 RID: 1011
	[Token(Token = "0x40003F3")]
	[FieldOffset(Offset = "0x58")]
	protected bool IsIngameShow;
}
