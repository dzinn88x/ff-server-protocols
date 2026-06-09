using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using UMA;
using UnityEngine;

namespace COW
{
	// Token: 0x02001445 RID: 5189
	[Token(Token = "0x2001445")]
	public class UIAvatarBase : Entity
	{
		// Token: 0x06005644 RID: 22084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005644")]
		[Address(RVA = "0x1B22694", Offset = "0x1B22694", VA = "0x7BBC322694")]
		private void InitRecipeDic()
		{
		}

		// Token: 0x06005645 RID: 22085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005645")]
		[Address(RVA = "0x1B22698", Offset = "0x1B22698", VA = "0x7BBC322698", Slot = "20")]
		public virtual void InitAvatar(bool isLocal, bool isPreview = false, int textureScale = 1)
		{
		}

		// Token: 0x06005646 RID: 22086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005646")]
		[Address(RVA = "0x1B22FA0", Offset = "0x1B22FA0", VA = "0x7BBC322FA0")]
		public void HideRender(bool visble = false)
		{
		}

		// Token: 0x06005647 RID: 22087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005647")]
		[Address(RVA = "0x1B23080", Offset = "0x1B23080", VA = "0x7BBC323080", Slot = "21")]
		protected virtual void OnInitAvatarBeforeBuild(bool isLocal)
		{
		}

		// Token: 0x06005648 RID: 22088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005648")]
		[Address(RVA = "0x1B23084", Offset = "0x1B23084", VA = "0x7BBC323084", Slot = "22")]
		protected virtual void CharacterCreatedCallback(UMAData umaData)
		{
		}

		// Token: 0x06005649 RID: 22089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005649")]
		[Address(RVA = "0x1B23220", Offset = "0x1B23220", VA = "0x7BBC323220")]
		private void OnCharacterReady(UMAData umaData)
		{
		}

		// Token: 0x0600564A RID: 22090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600564A")]
		[Address(RVA = "0x1B233E8", Offset = "0x1B233E8", VA = "0x7BBC3233E8", Slot = "23")]
		protected virtual void OnInitAvatarAfterBuild(bool isLocal)
		{
		}

		// Token: 0x0600564B RID: 22091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600564B")]
		[Address(RVA = "0x1B179E4", Offset = "0x1B179E4", VA = "0x7BBC3179E4", Slot = "24")]
		protected virtual void CharacterUpdateCallBack(UMAData umaData)
		{
		}

		// Token: 0x0600564C RID: 22092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600564C")]
		protected IEnumerator WaitUntilNotDirty<T>(Action<T> callback, T t)
		{
			return null;
		}

		// Token: 0x0600564D RID: 22093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600564D")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x113ED48", Offset = "0x113ED48")]
		private IEnumerator WaitUntilNotDirtyEnum<T>(Action<T> callback, T t)
		{
			return null;
		}

		// Token: 0x0600564E RID: 22094 RVA: 0x00019A40 File Offset: 0x00017C40
		[Token(Token = "0x600564E")]
		[Address(RVA = "0x1B233EC", Offset = "0x1B233EC", VA = "0x7BBC3233EC")]
		private bool IsUmaContextDestroyed()
		{
			return default(bool);
		}

		// Token: 0x0600564F RID: 22095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600564F")]
		[Address(RVA = "0x1B23468", Offset = "0x1B23468", VA = "0x7BBC323468", Slot = "25")]
		internal virtual void SetSlot(string recipe)
		{
		}

		// Token: 0x06005650 RID: 22096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005650")]
		[Address(RVA = "0x1B235A8", Offset = "0x1B235A8", VA = "0x7BBC3235A8", Slot = "26")]
		internal virtual void ClearSlot(string slot)
		{
		}

		// Token: 0x06005651 RID: 22097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005651")]
		[Address(RVA = "0x1B23684", Offset = "0x1B23684", VA = "0x7BBC323684", Slot = "27")]
		protected virtual void ClearAllSlots()
		{
		}

		// Token: 0x06005652 RID: 22098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005652")]
		[Address(RVA = "0x1B23750", Offset = "0x1B23750", VA = "0x7BBC323750", Slot = "28")]
		protected virtual void ClearClothesSlots()
		{
		}

		// Token: 0x06005653 RID: 22099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005653")]
		[Address(RVA = "0x1B179F0", Offset = "0x1B179F0", VA = "0x7BBC3179F0")]
		protected void ClearSlotRaw(UIModelAvatarBase.EWardrobeType t)
		{
		}

		// Token: 0x06005654 RID: 22100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005654")]
		[Address(RVA = "0x1B237AC", Offset = "0x1B237AC", VA = "0x7BBC3237AC", Slot = "29")]
		protected virtual void ChangeRace(string race)
		{
		}

		// Token: 0x06005655 RID: 22101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005655")]
		[Address(RVA = "0x1B1831C", Offset = "0x1B1831C", VA = "0x7BBC31831C")]
		protected void SetColor(Color c)
		{
		}

		// Token: 0x06005656 RID: 22102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005656")]
		[Address(RVA = "0x1B23874", Offset = "0x1B23874", VA = "0x7BBC323874", Slot = "30")]
		protected virtual void BuildAndUpdateAvatar()
		{
		}

		// Token: 0x06005657 RID: 22103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005657")]
		[Address(RVA = "0x1B23A00", Offset = "0x1B23A00", VA = "0x7BBC323A00")]
		public void BuildIfChanged()
		{
		}

		// Token: 0x06005658 RID: 22104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005658")]
		[Address(RVA = "0x1B23A1C", Offset = "0x1B23A1C", VA = "0x7BBC323A1C")]
		public void WaitBuildSync(bool removeNonDirty = true)
		{
		}

		// Token: 0x06005659 RID: 22105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005659")]
		[Address(RVA = "0x1B23BF8", Offset = "0x1B23BF8", VA = "0x7BBC323BF8")]
		public void HidekinMeshRenderer(bool b)
		{
		}

		// Token: 0x0600565A RID: 22106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600565A")]
		[Address(RVA = "0x1B23EB8", Offset = "0x1B23EB8", VA = "0x7BBC323EB8")]
		public void SetCharacterAway(bool isaway)
		{
		}

		// Token: 0x0600565B RID: 22107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600565B")]
		[Address(RVA = "0x1B184BC", Offset = "0x1B184BC", VA = "0x7BBC3184BC")]
		public UIAvatarBase()
		{
		}

		// Token: 0x04007AFC RID: 31484
		[Token(Token = "0x4007AFC")]
		[FieldOffset(Offset = "0x30")]
		public SharedColorTable SkinColor;

		// Token: 0x04007AFD RID: 31485
		[Token(Token = "0x4007AFD")]
		[FieldOffset(Offset = "0x38")]
		protected IUmaAvatar m_Avatar;

		// Token: 0x04007AFE RID: 31486
		[Token(Token = "0x4007AFE")]
		[FieldOffset(Offset = "0x40")]
		protected GameObject m_AvatarGo;

		// Token: 0x04007AFF RID: 31487
		[Token(Token = "0x4007AFF")]
		[FieldOffset(Offset = "0x48")]
		public LobbyAvatarClothEffectComponent m_ClothEffectComponent;

		// Token: 0x04007B00 RID: 31488
		[Token(Token = "0x4007B00")]
		[FieldOffset(Offset = "0x50")]
		protected AvatarEffect m_AvatarEffect;

		// Token: 0x04007B01 RID: 31489
		[Token(Token = "0x4007B01")]
		[FieldOffset(Offset = "0x58")]
		protected bool m_IsLocalAvatar;

		// Token: 0x04007B02 RID: 31490
		[Token(Token = "0x4007B02")]
		[FieldOffset(Offset = "0x59")]
		protected bool m_AvatarReady;

		// Token: 0x04007B03 RID: 31491
		[Token(Token = "0x4007B03")]
		[FieldOffset(Offset = "0x5A")]
		protected bool m_AvatarCreated;

		// Token: 0x04007B04 RID: 31492
		[Token(Token = "0x4007B04")]
		[FieldOffset(Offset = "0x5B")]
		protected bool m_PendingChangesForBuild;

		// Token: 0x04007B05 RID: 31493
		[Token(Token = "0x4007B05")]
		[FieldOffset(Offset = "0x5C")]
		protected bool m_HidingSkinRender;

		// Token: 0x04007B06 RID: 31494
		[Token(Token = "0x4007B06")]
		[FieldOffset(Offset = "0x5D")]
		protected bool m_IsPreviewAvatar;

		// Token: 0x04007B07 RID: 31495
		[Token(Token = "0x4007B07")]
		[FieldOffset(Offset = "0x5E")]
		public bool SkipInitBuild;

		// Token: 0x02001446 RID: 5190
		[Token(Token = "0x2001446")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10ECB20", Offset = "0x10ECB20")]
		private sealed class <WaitUntilNotDirtyEnum>d__21<T> : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600565C RID: 22108 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600565C")]
			[DebuggerHidden]
			public <WaitUntilNotDirtyEnum>d__21(int <>1__state)
			{
			}

			// Token: 0x0600565D RID: 22109 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600565D")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600565E RID: 22110 RVA: 0x00019A58 File Offset: 0x00017C58
			[Token(Token = "0x600565E")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000888 RID: 2184
			// (get) Token: 0x0600565F RID: 22111 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000888")]
			private object Current
			{
				[Token(Token = "0x600565F")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06005660 RID: 22112 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005660")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000889 RID: 2185
			// (get) Token: 0x06005661 RID: 22113 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000889")]
			private object Current
			{
				[Token(Token = "0x6005661")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04007B08 RID: 31496
			[Token(Token = "0x4007B08")]
			[FieldOffset(Offset = "0x0")]
			private int <>1__state;

			// Token: 0x04007B09 RID: 31497
			[Token(Token = "0x4007B09")]
			[FieldOffset(Offset = "0x0")]
			private object <>2__current;

			// Token: 0x04007B0A RID: 31498
			[Token(Token = "0x4007B0A")]
			[FieldOffset(Offset = "0x0")]
			public UIAvatarBase <>4__this;

			// Token: 0x04007B0B RID: 31499
			[Token(Token = "0x4007B0B")]
			[FieldOffset(Offset = "0x0")]
			public Action<T> callback;

			// Token: 0x04007B0C RID: 31500
			[Token(Token = "0x4007B0C")]
			[FieldOffset(Offset = "0x0")]
			public T t;
		}
	}
}
