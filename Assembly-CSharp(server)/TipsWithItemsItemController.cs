using System;
using COW;
using GCommon;
using Il2CppDummyDll;

// Token: 0x020000FF RID: 255
[Token(Token = "0x20000FF")]
public class TipsWithItemsItemController : UIBaseController, ITipsWithItemsItem
{
	// Token: 0x17000045 RID: 69
	// (get) Token: 0x060004AA RID: 1194 RVA: 0x00002C88 File Offset: 0x00000E88
	// (set) Token: 0x060004A9 RID: 1193 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000045")]
	public int m_Height
	{
		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x22666CC", Offset = "0x22666CC", VA = "0x7BBCA666CC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1132D4C", Offset = "0x1132D4C")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x22666EC", Offset = "0x22666EC", VA = "0x7BBCA666EC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1132D3C", Offset = "0x1132D3C")]
		private set
		{
		}
	}

	// Token: 0x060004AB RID: 1195 RVA: 0x00002CA0 File Offset: 0x00000EA0
	[Token(Token = "0x60004AB")]
	[Address(RVA = "0x22666F4", Offset = "0x22666F4", VA = "0x7BBCA666F4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	// Token: 0x060004AC RID: 1196 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004AC")]
	[Address(RVA = "0x2266744", Offset = "0x2266744", VA = "0x7BBCA66744", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	// Token: 0x060004AD RID: 1197 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004AD")]
	[Address(RVA = "0x22667A8", Offset = "0x22667A8", VA = "0x7BBCA667A8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	// Token: 0x060004AE RID: 1198 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004AE")]
	[Address(RVA = "0x2266568", Offset = "0x2266568", VA = "0x7BBCA66568", Slot = "28")]
	public void SetData(TipsWithItemsItemVO vo)
	{
	}

	// Token: 0x060004AF RID: 1199 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004AF")]
	[Address(RVA = "0x22667B0", Offset = "0x22667B0", VA = "0x7BBCA667B0")]
	public TipsWithItemsItemController()
	{
	}

	// Token: 0x040003FD RID: 1021
	[Token(Token = "0x40003FD")]
	[FieldOffset(Offset = "0x58")]
	private TipsWithItemsItemView m_View;

	// Token: 0x040003FE RID: 1022
	[Token(Token = "0x40003FE")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FFFBC", Offset = "0x10FFFBC")]
	private int <m_Height>k__BackingField;

	// Token: 0x040003FF RID: 1023
	[Token(Token = "0x40003FF")]
	[FieldOffset(Offset = "0x64")]
	private int m_TitleHeight;

	// Token: 0x04000400 RID: 1024
	[Token(Token = "0x4000400")]
	[FieldOffset(Offset = "0x68")]
	private int m_ContentHeight;
}
