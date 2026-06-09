using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x0200164E RID: 5710
	[Token(Token = "0x200164E")]
	internal class UIHudBigHeadResultShowController : UIHudResultShowBaseController
	{
		// Token: 0x0600670F RID: 26383 RVA: 0x0001D658 File Offset: 0x0001B858
		[Token(Token = "0x600670F")]
		[Address(RVA = "0x1895134", Offset = "0x1895134", VA = "0x7BBC095134")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006710 RID: 26384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006710")]
		[Address(RVA = "0x1895184", Offset = "0x1895184", VA = "0x7BBC095184", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006711 RID: 26385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006711")]
		[Address(RVA = "0x189539C", Offset = "0x189539C", VA = "0x7BBC09539C")]
		private void AjustLayoutForNotch()
		{
		}

		// Token: 0x06006712 RID: 26386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006712")]
		[Address(RVA = "0x1895580", Offset = "0x1895580", VA = "0x7BBC095580", Slot = "36")]
		public override void CreateProfileCallSign(PlayerData data, int index)
		{
		}

		// Token: 0x06006713 RID: 26387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006713")]
		[Address(RVA = "0x1895600", Offset = "0x1895600", VA = "0x7BBC095600", Slot = "39")]
		protected override void InitResultShowWindow()
		{
		}

		// Token: 0x06006714 RID: 26388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006714")]
		[Address(RVA = "0x18958BC", Offset = "0x18958BC", VA = "0x7BBC0958BC", Slot = "30")]
		protected override void OnMatchStatsChange(MatchStats stats, MatchIncome income)
		{
		}

		// Token: 0x06006715 RID: 26389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006715")]
		[Address(RVA = "0x18956AC", Offset = "0x18956AC", VA = "0x7BBC0956AC")]
		public void InitRank(int rank)
		{
		}

		// Token: 0x06006716 RID: 26390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006716")]
		[Address(RVA = "0x18959F4", Offset = "0x18959F4", VA = "0x7BBC0959F4", Slot = "37")]
		protected override void PlayAvatarsEmote()
		{
		}

		// Token: 0x06006717 RID: 26391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006717")]
		[Address(RVA = "0x1895BE8", Offset = "0x1895BE8", VA = "0x7BBC095BE8")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1140900", Offset = "0x1140900")]
		protected IEnumerator PlayEmote(UIMaleAvatar avatar, EmoteData data)
		{
			return null;
		}

		// Token: 0x06006718 RID: 26392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006718")]
		[Address(RVA = "0x1895CAC", Offset = "0x1895CAC", VA = "0x7BBC095CAC")]
		public UIHudBigHeadResultShowController()
		{
		}

		// Token: 0x0400848B RID: 33931
		[Token(Token = "0x400848B")]
		[FieldOffset(Offset = "0xD8")]
		private UIHudBigHeadResultShowView m_View;

		// Token: 0x0200164F RID: 5711
		[Token(Token = "0x200164F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EFF8C", Offset = "0x10EFF8C")]
		private sealed class <PlayEmote>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006719 RID: 26393 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006719")]
			[Address(RVA = "0x1895C80", Offset = "0x1895C80", VA = "0x7BBC095C80")]
			[DebuggerHidden]
			public <PlayEmote>d__9(int <>1__state)
			{
			}

			// Token: 0x0600671A RID: 26394 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600671A")]
			[Address(RVA = "0x1895CB4", Offset = "0x1895CB4", VA = "0x7BBC095CB4", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600671B RID: 26395 RVA: 0x0001D670 File Offset: 0x0001B870
			[Token(Token = "0x600671B")]
			[Address(RVA = "0x1895CB8", Offset = "0x1895CB8", VA = "0x7BBC095CB8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000909 RID: 2313
			// (get) Token: 0x0600671C RID: 26396 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000909")]
			private object Current
			{
				[Token(Token = "0x600671C")]
				[Address(RVA = "0x1895DE0", Offset = "0x1895DE0", VA = "0x7BBC095DE0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600671D RID: 26397 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600671D")]
			[Address(RVA = "0x1895DE8", Offset = "0x1895DE8", VA = "0x7BBC095DE8", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x1700090A RID: 2314
			// (get) Token: 0x0600671E RID: 26398 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700090A")]
			private object Current
			{
				[Token(Token = "0x600671E")]
				[Address(RVA = "0x1895E50", Offset = "0x1895E50", VA = "0x7BBC095E50", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400848C RID: 33932
			[Token(Token = "0x400848C")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400848D RID: 33933
			[Token(Token = "0x400848D")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400848E RID: 33934
			[Token(Token = "0x400848E")]
			[FieldOffset(Offset = "0x20")]
			public EmoteData data;

			// Token: 0x0400848F RID: 33935
			[Token(Token = "0x400848F")]
			[FieldOffset(Offset = "0x28")]
			public UIMaleAvatar avatar;

			// Token: 0x04008490 RID: 33936
			[Token(Token = "0x4008490")]
			[FieldOffset(Offset = "0x30")]
			private float <length>5__2;
		}
	}
}
