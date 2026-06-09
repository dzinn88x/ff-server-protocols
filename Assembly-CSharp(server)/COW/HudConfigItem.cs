using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200110D RID: 4365
	[Token(Token = "0x200110D")]
	public class HudConfigItem
	{
		// Token: 0x06004445 RID: 17477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004445")]
		[Address(RVA = "0x1859998", Offset = "0x1859998", VA = "0x7BBC059998")]
		public HudConfigItem()
		{
		}

		// Token: 0x06004446 RID: 17478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004446")]
		[Address(RVA = "0x1859A08", Offset = "0x1859A08", VA = "0x7BBC059A08")]
		public HudConfigItem(HudConfigItem item)
		{
		}

		// Token: 0x06004447 RID: 17479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004447")]
		[Address(RVA = "0x1859B9C", Offset = "0x1859B9C", VA = "0x7BBC059B9C")]
		public void SetValueFromExistItem(HudConfigItem item)
		{
		}

		// Token: 0x06004448 RID: 17480 RVA: 0x00014FB8 File Offset: 0x000131B8
		[Token(Token = "0x6004448")]
		[Address(RVA = "0x1859CD0", Offset = "0x1859CD0", VA = "0x7BBC059CD0")]
		public bool EqualTo(HudConfigItem item)
		{
			return default(bool);
		}

		// Token: 0x04005442 RID: 21570
		[Token(Token = "0x4005442")]
		[FieldOffset(Offset = "0x10")]
		public double CoordinateX;

		// Token: 0x04005443 RID: 21571
		[Token(Token = "0x4005443")]
		[FieldOffset(Offset = "0x18")]
		public double CoordinateY;

		// Token: 0x04005444 RID: 21572
		[Token(Token = "0x4005444")]
		[FieldOffset(Offset = "0x20")]
		public EUIAnchor Anchor;

		// Token: 0x04005445 RID: 21573
		[Token(Token = "0x4005445")]
		[FieldOffset(Offset = "0x28")]
		public double BtnScale;

		// Token: 0x04005446 RID: 21574
		[Token(Token = "0x4005446")]
		[FieldOffset(Offset = "0x30")]
		public double BtnMaxScale;

		// Token: 0x04005447 RID: 21575
		[Token(Token = "0x4005447")]
		[FieldOffset(Offset = "0x38")]
		public double BtnMinScale;

		// Token: 0x04005448 RID: 21576
		[Token(Token = "0x4005448")]
		[FieldOffset(Offset = "0x40")]
		public double ShowAlpha;

		// Token: 0x04005449 RID: 21577
		[Token(Token = "0x4005449")]
		[FieldOffset(Offset = "0x48")]
		public bool Locked;

		// Token: 0x0400544A RID: 21578
		[Token(Token = "0x400544A")]
		[FieldOffset(Offset = "0x50")]
		public string HudName;

		// Token: 0x0400544B RID: 21579
		[Token(Token = "0x400544B")]
		[FieldOffset(Offset = "0x58")]
		public bool Hidden;
	}
}
