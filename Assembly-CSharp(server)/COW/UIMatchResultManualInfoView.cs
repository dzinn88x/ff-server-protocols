using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200243A RID: 9274
	[Token(Token = "0x200243A")]
	internal class UIMatchResultManualInfoView : UIBaseView
	{
		// Token: 0x0600C384 RID: 50052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C384")]
		[Address(RVA = "0x147A914", Offset = "0x147A914", VA = "0x7BBBC7A914", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C385 RID: 50053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C385")]
		[Address(RVA = "0x147A9B0", Offset = "0x147A9B0", VA = "0x7BBBC7A9B0")]
		public UIMatchResultManualInfoView()
		{
		}

		// Token: 0x0400E703 RID: 59139
		[Token(Token = "0x400E703")]
		[FieldOffset(Offset = "0x20")]
		public UILabel ManualAchieveLabel;
	}
}
