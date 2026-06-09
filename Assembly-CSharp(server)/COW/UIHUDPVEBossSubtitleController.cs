using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001622 RID: 5666
	[Token(Token = "0x2001622")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EFBFC", Offset = "0x10EFBFC")]
	public class UIHUDPVEBossSubtitleController : UIBaseController
	{
		// Token: 0x060065DD RID: 26077 RVA: 0x0001D178 File Offset: 0x0001B378
		[Token(Token = "0x60065DD")]
		[Address(RVA = "0x16B9A28", Offset = "0x16B9A28", VA = "0x7BBBEB9A28")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060065DE RID: 26078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065DE")]
		[Address(RVA = "0x16B9A78", Offset = "0x16B9A78", VA = "0x7BBBEB9A78", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060065DF RID: 26079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065DF")]
		[Address(RVA = "0x16B9B04", Offset = "0x16B9B04", VA = "0x7BBBEB9B04")]
		public void OnSubtitleInfoCome(string content, ResourceID voiceResID, float duration)
		{
		}

		// Token: 0x060065E0 RID: 26080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065E0")]
		[Address(RVA = "0x16B9BBC", Offset = "0x16B9BBC", VA = "0x7BBBEB9BBC")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x114053C", Offset = "0x114053C")]
		private IEnumerator OnShow(string content, ResourceID voiceResID, float duration)
		{
			return null;
		}

		// Token: 0x060065E1 RID: 26081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065E1")]
		[Address(RVA = "0x16B9CB4", Offset = "0x16B9CB4", VA = "0x7BBBEB9CB4")]
		public UIHUDPVEBossSubtitleController()
		{
		}

		// Token: 0x040083E7 RID: 33767
		[Token(Token = "0x40083E7")]
		[FieldOffset(Offset = "0x58")]
		private HUDPVEBossSubtitleView m_View;

		// Token: 0x040083E8 RID: 33768
		[Token(Token = "0x40083E8")]
		[FieldOffset(Offset = "0x60")]
		private bool isPlaying;

		// Token: 0x02001623 RID: 5667
		[Token(Token = "0x2001623")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EFC34", Offset = "0x10EFC34")]
		private sealed class <OnShow>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060065E2 RID: 26082 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60065E2")]
			[Address(RVA = "0x16B9C88", Offset = "0x16B9C88", VA = "0x7BBBEB9C88")]
			[DebuggerHidden]
			public <OnShow>d__5(int <>1__state)
			{
			}

			// Token: 0x060065E3 RID: 26083 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60065E3")]
			[Address(RVA = "0x16B9CBC", Offset = "0x16B9CBC", VA = "0x7BBBEB9CBC", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060065E4 RID: 26084 RVA: 0x0001D190 File Offset: 0x0001B390
			[Token(Token = "0x60065E4")]
			[Address(RVA = "0x16B9CC0", Offset = "0x16B9CC0", VA = "0x7BBBEB9CC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170008FC RID: 2300
			// (get) Token: 0x060065E5 RID: 26085 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170008FC")]
			private object Current
			{
				[Token(Token = "0x60065E5")]
				[Address(RVA = "0x16B9ED0", Offset = "0x16B9ED0", VA = "0x7BBBEB9ED0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060065E6 RID: 26086 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60065E6")]
			[Address(RVA = "0x16B9ED8", Offset = "0x16B9ED8", VA = "0x7BBBEB9ED8", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170008FD RID: 2301
			// (get) Token: 0x060065E7 RID: 26087 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170008FD")]
			private object Current
			{
				[Token(Token = "0x60065E7")]
				[Address(RVA = "0x16B9F40", Offset = "0x16B9F40", VA = "0x7BBBEB9F40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040083E9 RID: 33769
			[Token(Token = "0x40083E9")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040083EA RID: 33770
			[Token(Token = "0x40083EA")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040083EB RID: 33771
			[Token(Token = "0x40083EB")]
			[FieldOffset(Offset = "0x20")]
			public UIHUDPVEBossSubtitleController <>4__this;

			// Token: 0x040083EC RID: 33772
			[Token(Token = "0x40083EC")]
			[FieldOffset(Offset = "0x28")]
			public string content;

			// Token: 0x040083ED RID: 33773
			[Token(Token = "0x40083ED")]
			[FieldOffset(Offset = "0x30")]
			public ResourceID voiceResID;

			// Token: 0x040083EE RID: 33774
			[Token(Token = "0x40083EE")]
			[FieldOffset(Offset = "0x34")]
			public float duration;
		}
	}
}
