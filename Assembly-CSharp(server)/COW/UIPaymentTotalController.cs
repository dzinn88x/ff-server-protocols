using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001ADF RID: 6879
	[Token(Token = "0x2001ADF")]
	public class UIPaymentTotalController : UIPaymentController.PaymentTabContentController
	{
		// Token: 0x060091C4 RID: 37316 RVA: 0x00026CE8 File Offset: 0x00024EE8
		[Token(Token = "0x60091C4")]
		[Address(RVA = "0x1F3819C", Offset = "0x1F3819C", VA = "0x7BBC73819C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060091C5 RID: 37317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60091C5")]
		[Address(RVA = "0x1F381EC", Offset = "0x1F381EC", VA = "0x7BBC7381EC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060091C6 RID: 37318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60091C6")]
		[Address(RVA = "0x1F3833C", Offset = "0x1F3833C", VA = "0x7BBC73833C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060091C7 RID: 37319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60091C7")]
		[Address(RVA = "0x1F38344", Offset = "0x1F38344", VA = "0x7BBC738344", Slot = "29")]
		public override void RefreshContent()
		{
		}

		// Token: 0x060091C8 RID: 37320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60091C8")]
		[Address(RVA = "0x1F38D8C", Offset = "0x1F38D8C", VA = "0x7BBC738D8C")]
		private void UpdateProgressBar(uint currentProgress, uint[] progressValues)
		{
		}

		// Token: 0x060091C9 RID: 37321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60091C9")]
		[Address(RVA = "0x1F3995C", Offset = "0x1F3995C", VA = "0x7BBC73995C")]
		private void OnGotoButtonClick()
		{
		}

		// Token: 0x060091CA RID: 37322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60091CA")]
		[Address(RVA = "0x1F39970", Offset = "0x1F39970", VA = "0x7BBC739970")]
		public UIPaymentTotalController()
		{
		}

		// Token: 0x04009C9D RID: 40093
		[Token(Token = "0x4009C9D")]
		[FieldOffset(Offset = "0x58")]
		private UIPaymentTotalView m_View;

		// Token: 0x04009C9E RID: 40094
		[Token(Token = "0x4009C9E")]
		[FieldOffset(Offset = "0x60")]
		private UIModelActivity m_Activity;

		// Token: 0x04009C9F RID: 40095
		[Token(Token = "0x4009C9F")]
		[FieldOffset(Offset = "0x68")]
		private List<UIPaymentTotalItemController> m_Items;

		// Token: 0x04009CA0 RID: 40096
		[Token(Token = "0x4009CA0")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color TIER_SPRITE_COLOR_GREY;

		// Token: 0x04009CA1 RID: 40097
		[Token(Token = "0x4009CA1")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Color TIER_SPRITE_COLOR_BLUE;

		// Token: 0x04009CA2 RID: 40098
		[Token(Token = "0x4009CA2")]
		[FieldOffset(Offset = "0x20")]
		private static readonly Color TIER_LABEL_COLOR_GREY;

		// Token: 0x04009CA3 RID: 40099
		[Token(Token = "0x4009CA3")]
		[FieldOffset(Offset = "0x30")]
		private static readonly Color TIER_LABEL_COLOR_WHITE;

		// Token: 0x02001AE0 RID: 6880
		[Token(Token = "0x2001AE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F8D34", Offset = "0x10F8D34")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060091CD RID: 37325 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60091CD")]
			[Address(RVA = "0x1F39B78", Offset = "0x1F39B78", VA = "0x7BBC739B78")]
			public <>c()
			{
			}

			// Token: 0x060091CE RID: 37326 RVA: 0x00026D00 File Offset: 0x00024F00
			[Token(Token = "0x60091CE")]
			[Address(RVA = "0x1F39B80", Offset = "0x1F39B80", VA = "0x7BBC739B80")]
			internal int <UpdateProgressBar>b__11_0(uint p1, uint p2)
			{
				return 0;
			}

			// Token: 0x04009CA4 RID: 40100
			[Token(Token = "0x4009CA4")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIPaymentTotalController.<>c <>9;

			// Token: 0x04009CA5 RID: 40101
			[Token(Token = "0x4009CA5")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<uint> <>9__11_0;
		}
	}
}
