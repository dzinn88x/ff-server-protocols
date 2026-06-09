using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000EEE RID: 3822
	[Token(Token = "0x2000EEE")]
	public class AnimationRuntimeHandle
	{
		// Token: 0x170006AE RID: 1710
		// (set) Token: 0x06003554 RID: 13652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006AE")]
		public bool IsLooping
		{
			[Token(Token = "0x6003554")]
			[Address(RVA = "0x25D9F54", Offset = "0x25D9F54", VA = "0x7BBCDD9F54")]
			set
			{
			}
		}

		// Token: 0x06003555 RID: 13653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003555")]
		[Address(RVA = "0x25D9F60", Offset = "0x25D9F60", VA = "0x7BBCDD9F60")]
		public void Reset(Animator animator, AnimationConfigData data)
		{
		}

		// Token: 0x06003556 RID: 13654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003556")]
		[Address(RVA = "0x25D9FA0", Offset = "0x25D9FA0", VA = "0x7BBCDD9FA0")]
		public void SetAction(Action<float> callback)
		{
		}

		// Token: 0x06003557 RID: 13655 RVA: 0x00010110 File Offset: 0x0000E310
		[Token(Token = "0x6003557")]
		[Address(RVA = "0x25D9FA8", Offset = "0x25D9FA8", VA = "0x7BBCDD9FA8")]
		private AnimatorStateInfo GetCurrentAnimatorStateInfo(int layer)
		{
			return default(AnimatorStateInfo);
		}

		// Token: 0x06003558 RID: 13656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003558")]
		[Address(RVA = "0x25DA040", Offset = "0x25DA040", VA = "0x7BBCDDA040")]
		public void CheckEnding(AnimationSystemComponent aniSys, int layer)
		{
		}

		// Token: 0x06003559 RID: 13657 RVA: 0x00010128 File Offset: 0x0000E328
		[Token(Token = "0x6003559")]
		[Address(RVA = "0x25DA240", Offset = "0x25DA240", VA = "0x7BBCDDA240")]
		public int GetAnimID()
		{
			return 0;
		}

		// Token: 0x0600355A RID: 13658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600355A")]
		[Address(RVA = "0x25DA2E0", Offset = "0x25DA2E0", VA = "0x7BBCDDA2E0", Slot = "4")]
		protected virtual void OnReset()
		{
		}

		// Token: 0x0600355B RID: 13659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600355B")]
		[Address(RVA = "0x25DA2E4", Offset = "0x25DA2E4", VA = "0x7BBCDDA2E4")]
		internal void SetAnimationFinished()
		{
		}

		// Token: 0x0600355C RID: 13660 RVA: 0x00010140 File Offset: 0x0000E340
		[Token(Token = "0x600355C")]
		[Address(RVA = "0x25DA2F0", Offset = "0x25DA2F0", VA = "0x7BBCDDA2F0", Slot = "5")]
		public virtual bool CanInterrupted()
		{
			return default(bool);
		}

		// Token: 0x0600355D RID: 13661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600355D")]
		[Address(RVA = "0x25DA318", Offset = "0x25DA318", VA = "0x7BBCDDA318")]
		public AnimationRuntimeHandle()
		{
		}

		// Token: 0x040048AE RID: 18606
		[Token(Token = "0x40048AE")]
		[FieldOffset(Offset = "0x10")]
		protected Animator m_Animator;

		// Token: 0x040048AF RID: 18607
		[Token(Token = "0x40048AF")]
		[FieldOffset(Offset = "0x18")]
		protected AnimationConfigData m_ConfigData;

		// Token: 0x040048B0 RID: 18608
		[Token(Token = "0x40048B0")]
		[FieldOffset(Offset = "0x20")]
		protected bool m_HasFinished;

		// Token: 0x040048B1 RID: 18609
		[Token(Token = "0x40048B1")]
		[FieldOffset(Offset = "0x24")]
		protected int m_CurrentNameHash;

		// Token: 0x040048B2 RID: 18610
		[Token(Token = "0x40048B2")]
		[FieldOffset(Offset = "0x28")]
		protected float m_LastTime;

		// Token: 0x040048B3 RID: 18611
		[Token(Token = "0x40048B3")]
		[FieldOffset(Offset = "0x2C")]
		protected bool m_IsLooping;

		// Token: 0x040048B4 RID: 18612
		[Token(Token = "0x40048B4")]
		[FieldOffset(Offset = "0x30")]
		protected Action<float> m_AnimatorCheck;
	}
}
