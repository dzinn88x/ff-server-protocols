using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200186A RID: 6250
	[Token(Token = "0x200186A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F4014", Offset = "0x10F4014")]
	public class UIHUDAOHKillPointsController : UIBaseController
	{
		// Token: 0x06007B40 RID: 31552 RVA: 0x00021E70 File Offset: 0x00020070
		[Token(Token = "0x6007B40")]
		[Address(RVA = "0x16AF5E8", Offset = "0x16AF5E8", VA = "0x7BBBEAF5E8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007B41 RID: 31553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B41")]
		[Address(RVA = "0x16AF638", Offset = "0x16AF638", VA = "0x7BBBEAF638", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007B42 RID: 31554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B42")]
		[Address(RVA = "0x16AFB00", Offset = "0x16AFB00", VA = "0x7BBBEAFB00", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06007B43 RID: 31555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B43")]
		[Address(RVA = "0x16AFBCC", Offset = "0x16AFBCC", VA = "0x7BBBEAFBCC")]
		private void OnPlayerLevelChange(object[] data)
		{
		}

		// Token: 0x06007B44 RID: 31556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B44")]
		[Address(RVA = "0x16AFC78", Offset = "0x16AFC78", VA = "0x7BBBEAFC78")]
		private void PlayPointsUpAnim()
		{
		}

		// Token: 0x06007B45 RID: 31557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007B45")]
		[Address(RVA = "0x16AFCBC", Offset = "0x16AFCBC", VA = "0x7BBBEAFCBC")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x11426F0", Offset = "0x11426F0")]
		private IEnumerator IEPointsUpAnim()
		{
			return null;
		}

		// Token: 0x06007B46 RID: 31558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B46")]
		[Address(RVA = "0x16AFD5C", Offset = "0x16AFD5C", VA = "0x7BBBEAFD5C")]
		private void LightingKillPoint(int index)
		{
		}

		// Token: 0x06007B47 RID: 31559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B47")]
		[Address(RVA = "0x16AF7C4", Offset = "0x16AF7C4", VA = "0x7BBBEAF7C4")]
		private void PrepareShowLevelEmptyPoint(int showLevel)
		{
		}

		// Token: 0x06007B48 RID: 31560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B48")]
		[Address(RVA = "0x16AFE20", Offset = "0x16AFE20", VA = "0x7BBBEAFE20")]
		public UIHUDAOHKillPointsController()
		{
		}

		// Token: 0x04008FD3 RID: 36819
		[Token(Token = "0x4008FD3")]
		[FieldOffset(Offset = "0x58")]
		private UIHUDAOHKillPointsView m_View;

		// Token: 0x04008FD4 RID: 36820
		[Token(Token = "0x4008FD4")]
		[FieldOffset(Offset = "0x60")]
		private int m_KillPoints;

		// Token: 0x04008FD5 RID: 36821
		[Token(Token = "0x4008FD5")]
		[FieldOffset(Offset = "0x64")]
		private int m_Level;

		// Token: 0x04008FD6 RID: 36822
		[Token(Token = "0x4008FD6")]
		[FieldOffset(Offset = "0x68")]
		private int m_CurShowLevel;

		// Token: 0x04008FD7 RID: 36823
		[Token(Token = "0x4008FD7")]
		[FieldOffset(Offset = "0x6C")]
		private int m_CurShowPoint;

		// Token: 0x04008FD8 RID: 36824
		[Token(Token = "0x4008FD8")]
		[FieldOffset(Offset = "0x70")]
		private Coroutine m_AnimHandle;

		// Token: 0x04008FD9 RID: 36825
		[Token(Token = "0x4008FD9")]
		[FieldOffset(Offset = "0x78")]
		private bool m_IsPlayingPointUpAnim;

		// Token: 0x04008FDA RID: 36826
		[Token(Token = "0x4008FDA")]
		[FieldOffset(Offset = "0x80")]
		protected BigHeadDataConfig m_BigHeadDataConfig;

		// Token: 0x04008FDB RID: 36827
		[Token(Token = "0x4008FDB")]
		[FieldOffset(Offset = "0x88")]
		private List<UIHUDArmsRacePointItem> m_PointItems;

		// Token: 0x0200186B RID: 6251
		[Token(Token = "0x200186B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F404C", Offset = "0x10F404C")]
		private sealed class <IEPointsUpAnim>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06007B49 RID: 31561 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B49")]
			[Address(RVA = "0x16AFD30", Offset = "0x16AFD30", VA = "0x7BBBEAFD30")]
			[DebuggerHidden]
			public <IEPointsUpAnim>d__14(int <>1__state)
			{
			}

			// Token: 0x06007B4A RID: 31562 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B4A")]
			[Address(RVA = "0x16AFE90", Offset = "0x16AFE90", VA = "0x7BBBEAFE90", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06007B4B RID: 31563 RVA: 0x00021E88 File Offset: 0x00020088
			[Token(Token = "0x6007B4B")]
			[Address(RVA = "0x16AFE94", Offset = "0x16AFE94", VA = "0x7BBBEAFE94", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000980 RID: 2432
			// (get) Token: 0x06007B4C RID: 31564 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000980")]
			private object Current
			{
				[Token(Token = "0x6007B4C")]
				[Address(RVA = "0x16B00A8", Offset = "0x16B00A8", VA = "0x7BBBEB00A8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06007B4D RID: 31565 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B4D")]
			[Address(RVA = "0x16B00B0", Offset = "0x16B00B0", VA = "0x7BBBEB00B0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000981 RID: 2433
			// (get) Token: 0x06007B4E RID: 31566 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000981")]
			private object Current
			{
				[Token(Token = "0x6007B4E")]
				[Address(RVA = "0x16B0118", Offset = "0x16B0118", VA = "0x7BBBEB0118", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04008FDC RID: 36828
			[Token(Token = "0x4008FDC")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04008FDD RID: 36829
			[Token(Token = "0x4008FDD")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04008FDE RID: 36830
			[Token(Token = "0x4008FDE")]
			[FieldOffset(Offset = "0x20")]
			public UIHUDAOHKillPointsController <>4__this;
		}
	}
}
