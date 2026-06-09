using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.HUD
{
	// Token: 0x0200265F RID: 9823
	[Token(Token = "0x200265F")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FE108", Offset = "0x10FE108")]
	public class UIHudEnermyPointController : UIHudNameBaseController
	{
		// Token: 0x0600CA8D RID: 51853 RVA: 0x00036720 File Offset: 0x00034920
		[Token(Token = "0x600CA8D")]
		[Address(RVA = "0x1767858", Offset = "0x1767858", VA = "0x7BBBF67858")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600CA8E RID: 51854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA8E")]
		[Address(RVA = "0x17678A8", Offset = "0x17678A8", VA = "0x7BBBF678A8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600CA8F RID: 51855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA8F")]
		[Address(RVA = "0x176790C", Offset = "0x176790C", VA = "0x7BBBF6790C")]
		public void BindEnermy({QAb\u0082~u hrVa^WJ, int q[JAWt], jImzVCP ^\u0082E}Zzs)
		{
		}

		// Token: 0x0600CA90 RID: 51856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA90")]
		[Address(RVA = "0x1767954", Offset = "0x1767954", VA = "0x7BBBF67954")]
		public void UnBindEnermy()
		{
		}

		// Token: 0x0600CA91 RID: 51857 RVA: 0x00036738 File Offset: 0x00034938
		[Token(Token = "0x600CA91")]
		[Address(RVA = "0x17679E0", Offset = "0x17679E0", VA = "0x7BBBF679E0", Slot = "29")]
		protected override bool NeedAutoScaleByDistance()
		{
			return default(bool);
		}

		// Token: 0x0600CA92 RID: 51858 RVA: 0x00036750 File Offset: 0x00034950
		[Token(Token = "0x600CA92")]
		[Address(RVA = "0x17679E8", Offset = "0x17679E8", VA = "0x7BBBF679E8", Slot = "31")]
		protected override bool NeedUpdatePosition()
		{
			return default(bool);
		}

		// Token: 0x0600CA93 RID: 51859 RVA: 0x00036768 File Offset: 0x00034968
		[Token(Token = "0x600CA93")]
		[Address(RVA = "0x176806C", Offset = "0x176806C", VA = "0x7BBBF6806C", Slot = "28")]
		protected override Vector3 TargetPosition()
		{
			return default(Vector3);
		}

		// Token: 0x0600CA94 RID: 51860 RVA: 0x00036780 File Offset: 0x00034980
		[Token(Token = "0x600CA94")]
		[Address(RVA = "0x1768200", Offset = "0x1768200", VA = "0x7BBBF68200")]
		private Vector3 gWjVKco(Player bqdVnD\u007F)
		{
			return default(Vector3);
		}

		// Token: 0x0600CA95 RID: 51861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA95")]
		[Address(RVA = "0x1768398", Offset = "0x1768398", VA = "0x7BBBF68398")]
		public UIHudEnermyPointController()
		{
		}

		// Token: 0x0400FF15 RID: 65301
		[Token(Token = "0x400FF15")]
		[FieldOffset(Offset = "0xA8")]
		private UIHudEnermyPointView p|r\u007Fnuf;

		// Token: 0x0400FF16 RID: 65302
		[Token(Token = "0x400FF16")]
		[FieldOffset(Offset = "0xB0")]
		private {QAb\u0082~u ^ee]Be;

		// Token: 0x0400FF17 RID: 65303
		[Token(Token = "0x400FF17")]
		[FieldOffset(Offset = "0xC8")]
		private int xvXDWaQ;

		// Token: 0x0400FF18 RID: 65304
		[Token(Token = "0x400FF18")]
		[FieldOffset(Offset = "0xCC")]
		private jImzVCP s\u007FDvaZv;

		// Token: 0x0400FF19 RID: 65305
		[Token(Token = "0x400FF19")]
		[FieldOffset(Offset = "0xD0")]
		public bool IsUsing;
	}
}
