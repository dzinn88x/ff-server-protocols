using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000EF0 RID: 3824
	[Token(Token = "0x2000EF0")]
	public class AnimationSystemComponent : MonoBehaviour
	{
		// Token: 0x06003561 RID: 13665 RVA: 0x00010158 File Offset: 0x0000E358
		[Token(Token = "0x6003561")]
		[Address(RVA = "0x25DA580", Offset = "0x25DA580", VA = "0x7BBCDDA580", Slot = "4")]
		protected virtual uint GetMaxLayerUsed()
		{
			return 0U;
		}

		// Token: 0x06003562 RID: 13666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003562")]
		[Address(RVA = "0x25DA588", Offset = "0x25DA588", VA = "0x7BBCDDA588", Slot = "5")]
		public virtual AnimationRuntimeHandle PlayAnim(AnimationID animID, bool canTransitionToSelf = false, float noramlized_time = 0f, bool useInstantSwitch = false, bool loop = false)
		{
			return null;
		}

		// Token: 0x06003563 RID: 13667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003563")]
		public AnimationRuntimeHandle PlayAnim<T>(AnimationID animID, bool canTransitionToSelf = false, float noramlized_time = 0f, bool useInstantSwitch = false, bool loop = false) where T : AnimationRuntimeHandle, new()
		{
			return null;
		}

		// Token: 0x06003564 RID: 13668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003564")]
		[Address(RVA = "0x25DA618", Offset = "0x25DA618", VA = "0x7BBCDDA618")]
		public void AddDefaultState(AnimationID animID)
		{
		}

		// Token: 0x06003565 RID: 13669 RVA: 0x00010170 File Offset: 0x0000E370
		[Token(Token = "0x6003565")]
		[Address(RVA = "0x25DA6A4", Offset = "0x25DA6A4", VA = "0x7BBCDDA6A4")]
		public bool IsPlaying(AnimationID animID)
		{
			return default(bool);
		}

		// Token: 0x06003566 RID: 13670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003566")]
		[Address(RVA = "0x25DA7FC", Offset = "0x25DA7FC", VA = "0x7BBCDDA7FC")]
		public AnimationRuntimeHandle GetCurrentRunningHandlerByAnimId(AnimationID animID)
		{
			return null;
		}

		// Token: 0x06003567 RID: 13671 RVA: 0x00010188 File Offset: 0x0000E388
		[Token(Token = "0x6003567")]
		[Address(RVA = "0x25DA80C", Offset = "0x25DA80C", VA = "0x7BBCDDA80C")]
		public AnimationID GetCurrentAnimID(int layerIndex)
		{
			return default(AnimationID);
		}

		// Token: 0x06003568 RID: 13672 RVA: 0x000101A0 File Offset: 0x0000E3A0
		[Token(Token = "0x6003568")]
		[Address(RVA = "0x25DA8C8", Offset = "0x25DA8C8", VA = "0x7BBCDDA8C8")]
		public bool CanInterrupted()
		{
			return default(bool);
		}

		// Token: 0x06003569 RID: 13673 RVA: 0x000101B8 File Offset: 0x0000E3B8
		[Token(Token = "0x6003569")]
		[Address(RVA = "0x25DA958", Offset = "0x25DA958", VA = "0x7BBCDDA958")]
		public bool CanInterrupted(int layerIndex)
		{
			return default(bool);
		}

		// Token: 0x0600356A RID: 13674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600356A")]
		[Address(RVA = "0x25DA984", Offset = "0x25DA984", VA = "0x7BBCDDA984")]
		public void TransitionAllLayerToDefaultState()
		{
		}

		// Token: 0x0600356B RID: 13675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600356B")]
		[Address(RVA = "0x25DA9E8", Offset = "0x25DA9E8", VA = "0x7BBCDDA9E8")]
		public void TransitionToDefaultState(int layerIndex)
		{
		}

		// Token: 0x0600356C RID: 13676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600356C")]
		[Address(RVA = "0x25DA9F4", Offset = "0x25DA9F4", VA = "0x7BBCDDA9F4")]
		public void PauseAnimation()
		{
		}

		// Token: 0x0600356D RID: 13677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600356D")]
		[Address(RVA = "0x25DAAB0", Offset = "0x25DAAB0", VA = "0x7BBCDDAAB0", Slot = "6")]
		public virtual void SwitchAnimController(RuntimeAnimatorController runCtrl)
		{
		}

		// Token: 0x0600356E RID: 13678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600356E")]
		[Address(RVA = "0x25DA1C0", Offset = "0x25DA1C0", VA = "0x7BBCDDA1C0")]
		internal void SetAnimationFinished(AnimationID animID, bool autoTransitionToDefaultState)
		{
		}

		// Token: 0x0600356F RID: 13679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600356F")]
		[Address(RVA = "0x25DABA8", Offset = "0x25DABA8", VA = "0x7BBCDDABA8", Slot = "7")]
		protected virtual void OnTransitionToDefaultState(int layerIndex)
		{
		}

		// Token: 0x06003570 RID: 13680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003570")]
		[Address(RVA = "0x25DA73C", Offset = "0x25DA73C", VA = "0x7BBCDDA73C")]
		private AnimationRuntimeHandle GetCurrentRunningHandler(int layerIndex)
		{
			return null;
		}

		// Token: 0x06003571 RID: 13681 RVA: 0x000101D0 File Offset: 0x0000E3D0
		[Token(Token = "0x6003571")]
		[Address(RVA = "0x25DAA40", Offset = "0x25DAA40", VA = "0x7BBCDDAA40")]
		public bool HasAnimator()
		{
			return default(bool);
		}

		// Token: 0x06003572 RID: 13682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003572")]
		protected virtual T PlayAnimInternal<T>(AnimationConfigData data, bool useInstantSwitch, float normalized_time = 0f, bool loop = false) where T : AnimationRuntimeHandle, new()
		{
			return null;
		}

		// Token: 0x06003573 RID: 13683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003573")]
		[Address(RVA = "0x25DAC54", Offset = "0x25DAC54", VA = "0x7BBCDDAC54", Slot = "9")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06003574 RID: 13684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003574")]
		[Address(RVA = "0x25DAE18", Offset = "0x25DAE18", VA = "0x7BBCDDAE18")]
		protected void UpdateCheckEnding()
		{
		}

		// Token: 0x06003575 RID: 13685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003575")]
		[Address(RVA = "0x25DAF08", Offset = "0x25DAF08", VA = "0x7BBCDDAF08", Slot = "10")]
		public virtual void EnableAnimator(bool enabled)
		{
		}

		// Token: 0x06003576 RID: 13686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003576")]
		[Address(RVA = "0x25DAF40", Offset = "0x25DAF40", VA = "0x7BBCDDAF40")]
		public AnimationSystemComponent()
		{
		}

		// Token: 0x040048BB RID: 18619
		[Token(Token = "0x40048BB")]
		private const uint MAX_ANIM_LAYER_NB = 8U;

		// Token: 0x040048BC RID: 18620
		[Token(Token = "0x40048BC")]
		[FieldOffset(Offset = "0x18")]
		protected Animator m_Animator;

		// Token: 0x040048BD RID: 18621
		[Token(Token = "0x40048BD")]
		[FieldOffset(Offset = "0x20")]
		protected AnimationRuntimeHandle[] m_CurrentHandles;

		// Token: 0x040048BE RID: 18622
		[Token(Token = "0x40048BE")]
		[FieldOffset(Offset = "0x28")]
		protected AnimationID[] m_DefaultAnims;

		// Token: 0x040048BF RID: 18623
		[Token(Token = "0x40048BF")]
		[FieldOffset(Offset = "0x30")]
		private int m_SwitchAnimationControllTickCount;

		// Token: 0x040048C0 RID: 18624
		[Token(Token = "0x40048C0")]
		[FieldOffset(Offset = "0x38")]
		public AnimationSystemComponent.AnimationComponentPlay OnAnimationComponentPlayCall;

		// Token: 0x02000EF1 RID: 3825
		// (Invoke) Token: 0x06003578 RID: 13688
		[Token(Token = "0x2000EF1")]
		public delegate void AnimationComponentPlay(AnimationID animID);
	}
}
