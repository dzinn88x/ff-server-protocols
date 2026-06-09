using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200141A RID: 5146
	[Token(Token = "0x200141A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EC678", Offset = "0x10EC678")]
	internal class UIHudADSpaceHintController : UIBaseController
	{
		// Token: 0x060054D4 RID: 21716 RVA: 0x00019530 File Offset: 0x00017730
		[Token(Token = "0x60054D4")]
		[Address(RVA = "0x1D62E24", Offset = "0x1D62E24", VA = "0x7BBC562E24")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060054D5 RID: 21717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054D5")]
		[Address(RVA = "0x1D62E74", Offset = "0x1D62E74", VA = "0x7BBC562E74", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060054D6 RID: 21718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054D6")]
		[Address(RVA = "0x1D63088", Offset = "0x1D63088", VA = "0x7BBC563088")]
		private void DeActiveAll()
		{
		}

		// Token: 0x060054D7 RID: 21719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054D7")]
		[Address(RVA = "0x1D63154", Offset = "0x1D63154", VA = "0x7BBC563154")]
		private void OnStart1v1InfoChange()
		{
		}

		// Token: 0x060054D8 RID: 21720 RVA: 0x00019548 File Offset: 0x00017748
		[Token(Token = "0x60054D8")]
		[Address(RVA = "0x1D63390", Offset = "0x1D63390", VA = "0x7BBC563390")]
		private float DurationForADSHintStyle(ADSHintStyle style)
		{
			return 0f;
		}

		// Token: 0x060054D9 RID: 21721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054D9")]
		[Address(RVA = "0x1D633B0", Offset = "0x1D633B0", VA = "0x7BBC5633B0")]
		public void SetData(ADSHintStyle style)
		{
		}

		// Token: 0x060054DA RID: 21722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054DA")]
		[Address(RVA = "0x1D63E08", Offset = "0x1D63E08", VA = "0x7BBC563E08")]
		private void ShowNextHint()
		{
		}

		// Token: 0x060054DB RID: 21723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054DB")]
		[Address(RVA = "0x1D63508", Offset = "0x1D63508", VA = "0x7BBC563508")]
		private void ShowHint(ADSHintStyle hintStyle)
		{
		}

		// Token: 0x060054DC RID: 21724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054DC")]
		[Address(RVA = "0x1D63F88", Offset = "0x1D63F88", VA = "0x7BBC563F88")]
		public UIHudADSpaceHintController()
		{
		}

		// Token: 0x060054DD RID: 21725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054DD")]
		[Address(RVA = "0x1D63FF8", Offset = "0x1D63FF8", VA = "0x7BBC563FF8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113E7FC", Offset = "0x113E7FC")]
		private void <SetData>b__8_0()
		{
		}

		// Token: 0x060054DE RID: 21726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054DE")]
		[Address(RVA = "0x1D6401C", Offset = "0x1D6401C", VA = "0x7BBC56401C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113E80C", Offset = "0x113E80C")]
		private void <ShowNextHint>b__9_0()
		{
		}

		// Token: 0x04007A1D RID: 31261
		[Token(Token = "0x4007A1D")]
		[FieldOffset(Offset = "0x58")]
		private UIHudADSpaceHintView m_View;

		// Token: 0x04007A1E RID: 31262
		[Token(Token = "0x4007A1E")]
		[FieldOffset(Offset = "0x60")]
		private uint m_HideDelayCall;

		// Token: 0x04007A1F RID: 31263
		[Token(Token = "0x4007A1F")]
		[FieldOffset(Offset = "0x68")]
		private Queue<ADSHintStyle> showHintQueue;

		// Token: 0x0200141B RID: 5147
		[Token(Token = "0x200141B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EC6B0", Offset = "0x10EC6B0")]
		private sealed class <>c__DisplayClass10_0
		{
			// Token: 0x060054DF RID: 21727 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60054DF")]
			[Address(RVA = "0x1D63F80", Offset = "0x1D63F80", VA = "0x7BBC563F80")]
			public <>c__DisplayClass10_0()
			{
			}

			// Token: 0x060054E0 RID: 21728 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60054E0")]
			[Address(RVA = "0x1D64040", Offset = "0x1D64040", VA = "0x7BBC564040")]
			internal void <ShowHint>b__0()
			{
			}

			// Token: 0x04007A20 RID: 31264
			[Token(Token = "0x4007A20")]
			[FieldOffset(Offset = "0x10")]
			public Bp}QoJw game;
		}
	}
}
