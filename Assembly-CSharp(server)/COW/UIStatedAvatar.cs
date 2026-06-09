using System;
using System.Collections.Generic;
using Beebyte.Obfuscator;
using GCommon;
using Il2CppDummyDll;
using UMA;
using UnityEngine;

namespace COW
{
	// Token: 0x02001454 RID: 5204
	[Token(Token = "0x2001454")]
	public class UIStatedAvatar : UIAnimedAvatar
	{
		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x06005744 RID: 22340 RVA: 0x00019DA0 File Offset: 0x00017FA0
		// (set) Token: 0x06005745 RID: 22341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700089A")]
		private protected bool IsMatchResult
		{
			[Token(Token = "0x6005744")]
			[Address(RVA = "0x2135640", Offset = "0x2135640", VA = "0x7BBC935640")]
			private get
			{
				return default(bool);
			}
			[Token(Token = "0x6005745")]
			[Address(RVA = "0x2135648", Offset = "0x2135648", VA = "0x7BBC935648")]
			protected set
			{
			}
		}

		// Token: 0x06005746 RID: 22342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005746")]
		[Address(RVA = "0x2135654", Offset = "0x2135654", VA = "0x7BBC935654")]
		public UIAvatarState GetCurrentState()
		{
			return null;
		}

		// Token: 0x06005747 RID: 22343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005747")]
		[Address(RVA = "0x21356C0", Offset = "0x21356C0", VA = "0x7BBC9356C0", Slot = "20")]
		public override void InitAvatar(bool isLocal, bool isPreview = false, int textureScale = 1)
		{
		}

		// Token: 0x06005748 RID: 22344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005748")]
		[Address(RVA = "0x2135734", Offset = "0x2135734", VA = "0x7BBC935734", Slot = "22")]
		protected override void CharacterCreatedCallback(UMAData umaData)
		{
		}

		// Token: 0x06005749 RID: 22345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005749")]
		[Address(RVA = "0x2135878", Offset = "0x2135878", VA = "0x7BBC935878", Slot = "23")]
		protected override void OnInitAvatarAfterBuild(bool isLocal)
		{
		}

		// Token: 0x0600574A RID: 22346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600574A")]
		[Address(RVA = "0x2135900", Offset = "0x2135900", VA = "0x7BBC935900", Slot = "24")]
		protected override void CharacterUpdateCallBack(UMAData umaData)
		{
		}

		// Token: 0x0600574B RID: 22347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600574B")]
		[Address(RVA = "0x2135AAC", Offset = "0x2135AAC", VA = "0x7BBC935AAC", Slot = "38")]
		public override void UpdateAnimator(CSSharedAvatarData aData, bool female)
		{
		}

		// Token: 0x0600574C RID: 22348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600574C")]
		[Address(RVA = "0x21359C0", Offset = "0x21359C0", VA = "0x7BBC9359C0")]
		protected void ProcessClothEffect()
		{
		}

		// Token: 0x0600574D RID: 22349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600574D")]
		[Address(RVA = "0x21365F0", Offset = "0x21365F0", VA = "0x7BBC9365F0")]
		public void ChangeLayer(int layer)
		{
		}

		// Token: 0x0600574E RID: 22350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600574E")]
		[Address(RVA = "0x2135B10", Offset = "0x2135B10", VA = "0x7BBC935B10")]
		protected void LoadClothEffect()
		{
		}

		// Token: 0x0600574F RID: 22351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600574F")]
		[Address(RVA = "0x2136868", Offset = "0x2136868", VA = "0x7BBC936868")]
		public void ShowLobbyEffectIntervals()
		{
		}

		// Token: 0x06005750 RID: 22352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005750")]
		[Address(RVA = "0x21368E8", Offset = "0x21368E8", VA = "0x7BBC9368E8")]
		private void _ShowLobbyEffect()
		{
		}

		// Token: 0x06005751 RID: 22353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005751")]
		[Address(RVA = "0x21369E4", Offset = "0x21369E4", VA = "0x7BBC9369E4")]
		private void _HideLobbyEffect()
		{
		}

		// Token: 0x06005752 RID: 22354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005752")]
		[Address(RVA = "0x21366BC", Offset = "0x21366BC", VA = "0x7BBC9366BC")]
		public void ResetLobbyAvatarEffect()
		{
		}

		// Token: 0x06005753 RID: 22355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005753")]
		[Address(RVA = "0x2136AE0", Offset = "0x2136AE0", VA = "0x7BBC936AE0")]
		public void ResetIdle()
		{
		}

		// Token: 0x06005754 RID: 22356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005754")]
		[Address(RVA = "0x21367A4", Offset = "0x21367A4", VA = "0x7BBC9367A4")]
		private void AddAvatarLobbyEffect(EventClothEffectsData data)
		{
		}

		// Token: 0x06005755 RID: 22357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005755")]
		[Address(RVA = "0x2136B04", Offset = "0x2136B04", VA = "0x7BBC936B04")]
		public void SetEventEffectsVisibilityIfNeed(bool isVisible)
		{
		}

		// Token: 0x06005756 RID: 22358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005756")]
		protected void CallbackOnce<T>(ref Action<T> callback, T param)
		{
		}

		// Token: 0x06005757 RID: 22359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005757")]
		[Address(RVA = "0x2136B74", Offset = "0x2136B74", VA = "0x7BBC936B74", Slot = "34")]
		public override void ResetAvatar()
		{
		}

		// Token: 0x06005758 RID: 22360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005758")]
		[Address(RVA = "0x21357EC", Offset = "0x21357EC", VA = "0x7BBC9357EC")]
		public void UpdateState(UIAvatarState s)
		{
		}

		// Token: 0x06005759 RID: 22361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005759")]
		[Address(RVA = "0x2136D80", Offset = "0x2136D80", VA = "0x7BBC936D80")]
		[SkipRename]
		protected void PlayAnimOneShotEvt(string animationResID)
		{
		}

		// Token: 0x0600575A RID: 22362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600575A")]
		[Address(RVA = "0x2136F00", Offset = "0x2136F00", VA = "0x7BBC936F00")]
		public void RefreshState()
		{
		}

		// Token: 0x0600575B RID: 22363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600575B")]
		[Address(RVA = "0x21380C8", Offset = "0x21380C8", VA = "0x7BBC9380C8")]
		public static void UpdateClothes(uint wId, List<uint> cs)
		{
		}

		// Token: 0x0600575C RID: 22364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600575C")]
		[Address(RVA = "0x21380F0", Offset = "0x21380F0", VA = "0x7BBC9380F0")]
		public static void UpdateClothes(AvatarWardrobeData wData, List<uint> cs)
		{
		}

		// Token: 0x0600575D RID: 22365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600575D")]
		[Address(RVA = "0x21382B4", Offset = "0x21382B4", VA = "0x7BBC9382B4")]
		public static void UpdateClothes(AvatarWardrobeData wData, UIAvatarState cs, bool removeConflictSlot, bool considerHidingTarget)
		{
		}

		// Token: 0x0600575E RID: 22366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600575E")]
		[Address(RVA = "0x21383A0", Offset = "0x21383A0", VA = "0x7BBC9383A0")]
		public static AvatarWardrobeData FindClothesWithAnimOrEffect(IEnumerable<uint> cs)
		{
			return null;
		}

		// Token: 0x0600575F RID: 22367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600575F")]
		[Address(RVA = "0x2138810", Offset = "0x2138810", VA = "0x7BBC938810")]
		public AvatarWardrobeData GetCurrentSlot(string slot)
		{
			return null;
		}

		// Token: 0x06005760 RID: 22368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005760")]
		[Address(RVA = "0x2136C20", Offset = "0x2136C20", VA = "0x7BBC936C20")]
		protected void CheckAndUpdateState(UIStatedAvatar.InternalState dst, UIAvatarState src)
		{
		}

		// Token: 0x06005761 RID: 22369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005761")]
		[Address(RVA = "0x2136F3C", Offset = "0x2136F3C", VA = "0x7BBC936F3C")]
		protected void UpdateState(UIStatedAvatar.InternalState dst, bool faceDirty, bool colorDirty, bool clothesDirty, out bool hidingSet, out string hidingSlot)
		{
		}

		// Token: 0x06005762 RID: 22370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005762")]
		[Address(RVA = "0x21388A0", Offset = "0x21388A0", VA = "0x7BBC9388A0")]
		private void CheckAndUpdateFaceClothes(UIStatedAvatar.InternalState dst, UIAvatarState src, ref bool faceDirty, ref bool colorDirty, ref bool clothesDirty)
		{
		}

		// Token: 0x06005763 RID: 22371 RVA: 0x00019DB8 File Offset: 0x00017FB8
		[Token(Token = "0x6005763")]
		[Address(RVA = "0x2138F44", Offset = "0x2138F44", VA = "0x7BBC938F44")]
		private bool CheckAndUpdateField(ref bool dst, bool src)
		{
			return default(bool);
		}

		// Token: 0x06005764 RID: 22372 RVA: 0x00019DD0 File Offset: 0x00017FD0
		[Token(Token = "0x6005764")]
		[Address(RVA = "0x2138F68", Offset = "0x2138F68", VA = "0x7BBC938F68")]
		private bool CheckAndUpdateField(ref uint dst, uint src)
		{
			return default(bool);
		}

		// Token: 0x06005765 RID: 22373 RVA: 0x00019DE8 File Offset: 0x00017FE8
		[Token(Token = "0x6005765")]
		[Address(RVA = "0x2138F88", Offset = "0x2138F88", VA = "0x7BBC938F88")]
		private bool CheckAndUpdateField(ref bool dst, UIAvatarStateTriggerValue<bool> src)
		{
			return default(bool);
		}

		// Token: 0x06005766 RID: 22374 RVA: 0x00019E00 File Offset: 0x00018000
		[Token(Token = "0x6005766")]
		[Address(RVA = "0x2138EBC", Offset = "0x2138EBC", VA = "0x7BBC938EBC")]
		private bool CheckAndUpdateField(ref uint dst, UIAvatarStateTriggerValue<uint> src)
		{
			return default(bool);
		}

		// Token: 0x06005767 RID: 22375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005767")]
		[Address(RVA = "0x2139014", Offset = "0x2139014", VA = "0x7BBC939014")]
		public UIStatedAvatar()
		{
		}

		// Token: 0x06005768 RID: 22376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005768")]
		[Address(RVA = "0x213913C", Offset = "0x213913C", VA = "0x7BBC93913C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113F1DC", Offset = "0x113F1DC")]
		private void <_ShowLobbyEffect>b__26_0()
		{
		}

		// Token: 0x06005769 RID: 22377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005769")]
		[Address(RVA = "0x21391D8", Offset = "0x21391D8", VA = "0x7BBC9391D8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113F1EC", Offset = "0x113F1EC")]
		private void <_HideLobbyEffect>b__27_0()
		{
		}

		// Token: 0x04007B92 RID: 31634
		[Token(Token = "0x4007B92")]
		[FieldOffset(Offset = "0x1A8")]
		protected UIStatedAvatar.InternalState m_InternalState;

		// Token: 0x04007B93 RID: 31635
		[Token(Token = "0x4007B93")]
		[FieldOffset(Offset = "0x1B0")]
		protected UIAvatarState m_CurrentState;

		// Token: 0x04007B94 RID: 31636
		[Token(Token = "0x4007B94")]
		[FieldOffset(Offset = "0x1B8")]
		protected Transform m_HeadTF;

		// Token: 0x04007B95 RID: 31637
		[Token(Token = "0x4007B95")]
		[FieldOffset(Offset = "0x1C0")]
		protected Transform m_HipTF;

		// Token: 0x04007B96 RID: 31638
		[Token(Token = "0x4007B96")]
		[FieldOffset(Offset = "0x1C8")]
		protected Transform m_RootTF;

		// Token: 0x04007B97 RID: 31639
		[Token(Token = "0x4007B97")]
		[FieldOffset(Offset = "0x1D0")]
		private bool m_IsMatchResult;

		// Token: 0x04007B98 RID: 31640
		[Token(Token = "0x4007B98")]
		[FieldOffset(Offset = "0x1D8")]
		private Dictionary<uint, EventClothEffectsData> m_IdtoLobbyShowClothEffectDic;

		// Token: 0x04007B99 RID: 31641
		[Token(Token = "0x4007B99")]
		[FieldOffset(Offset = "0x1E0")]
		private uint m_delayCallIDShow;

		// Token: 0x04007B9A RID: 31642
		[Token(Token = "0x4007B9A")]
		[FieldOffset(Offset = "0x1E4")]
		private uint m_delayCallIDHide;

		// Token: 0x04007B9B RID: 31643
		[Token(Token = "0x4007B9B")]
		[FieldOffset(Offset = "0x1E8")]
		private uint m_AvatarEffectShowTime;

		// Token: 0x04007B9C RID: 31644
		[Token(Token = "0x4007B9C")]
		[FieldOffset(Offset = "0x1EC")]
		private uint m_AvatarEffectHideTime;

		// Token: 0x04007B9D RID: 31645
		[Token(Token = "0x4007B9D")]
		[FieldOffset(Offset = "0x1F0")]
		private bool m_currentEventEffectsVisibility;

		// Token: 0x04007B9E RID: 31646
		[Token(Token = "0x4007B9E")]
		[FieldOffset(Offset = "0x1F1")]
		private bool m_IsShowSpecialIdle;

		// Token: 0x02001455 RID: 5205
		[Token(Token = "0x2001455")]
		protected class InternalState : UIAvatarStateBase
		{
			// Token: 0x0600576A RID: 22378 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600576A")]
			[Address(RVA = "0x21390CC", Offset = "0x21390CC", VA = "0x7BBC9390CC")]
			public InternalState()
			{
			}

			// Token: 0x04007B9F RID: 31647
			[Token(Token = "0x4007B9F")]
			[FieldOffset(Offset = "0x41")]
			public bool CurrentStateDirty;

			// Token: 0x04007BA0 RID: 31648
			[Token(Token = "0x4007BA0")]
			[FieldOffset(Offset = "0x44")]
			public uint LastSelectClothes;

			// Token: 0x04007BA1 RID: 31649
			[Token(Token = "0x4007BA1")]
			[FieldOffset(Offset = "0x48")]
			public bool LastPlayClothesChangeAnim;

			// Token: 0x04007BA2 RID: 31650
			[Token(Token = "0x4007BA2")]
			[FieldOffset(Offset = "0x49")]
			public bool LastPlayClothesIdleAnim;

			// Token: 0x04007BA3 RID: 31651
			[Token(Token = "0x4007BA3")]
			[FieldOffset(Offset = "0x50")]
			public Dictionary<string, AvatarWardrobeData> SlotClothes;
		}

		// Token: 0x02001456 RID: 5206
		[Token(Token = "0x2001456")]
		public class ClothEffectObject
		{
			// Token: 0x0600576B RID: 22379 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600576B")]
			[Address(RVA = "0x2139274", Offset = "0x2139274", VA = "0x7BBC939274")]
			public ClothEffectObject()
			{
			}

			// Token: 0x04007BA4 RID: 31652
			[Token(Token = "0x4007BA4")]
			[FieldOffset(Offset = "0x10")]
			public ResourceID ResId;

			// Token: 0x04007BA5 RID: 31653
			[Token(Token = "0x4007BA5")]
			[FieldOffset(Offset = "0x18")]
			public GameObject EffectGo;

			// Token: 0x04007BA6 RID: 31654
			[Token(Token = "0x4007BA6")]
			[FieldOffset(Offset = "0x20")]
			public BitArrayBoolean isVisible;
		}
	}
}
