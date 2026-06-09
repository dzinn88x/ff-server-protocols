using System;
using Il2CppDummyDll;
using UMA;
using UnityEngine;

namespace COW
{
	// Token: 0x02001447 RID: 5191
	[Token(Token = "0x2001447")]
	public class UIAvatar : UIAvatarBase
	{
		// Token: 0x06005662 RID: 22114 RVA: 0x00019A70 File Offset: 0x00017C70
		[Token(Token = "0x6005662")]
		[Address(RVA = "0x1B172B8", Offset = "0x1B172B8", VA = "0x7BBC3172B8")]
		public bool IsCurrentModelFemale()
		{
			return default(bool);
		}

		// Token: 0x06005663 RID: 22115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005663")]
		[Address(RVA = "0x1B172C0", Offset = "0x1B172C0", VA = "0x7BBC3172C0")]
		public static CSSharedAvatarData GetAvatarData(uint id)
		{
			return null;
		}

		// Token: 0x06005664 RID: 22116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005664")]
		[Address(RVA = "0x1B17348", Offset = "0x1B17348", VA = "0x7BBC317348")]
		public static AvatarWardrobeData GetWardrobeData(uint id)
		{
			return null;
		}

		// Token: 0x06005665 RID: 22117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005665")]
		[Address(RVA = "0x1B173D0", Offset = "0x1B173D0", VA = "0x7BBC3173D0")]
		public static string GetSlot(AvatarWardrobeData data)
		{
			return null;
		}

		// Token: 0x06005666 RID: 22118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005666")]
		[Address(RVA = "0x1B17438", Offset = "0x1B17438", VA = "0x7BBC317438")]
		internal void SetSlot(uint wId, bool isFemale, uint avatarId)
		{
		}

		// Token: 0x06005667 RID: 22119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005667")]
		[Address(RVA = "0x1B1747C", Offset = "0x1B1747C", VA = "0x7BBC31747C")]
		internal void SetSlot(AvatarWardrobeData wData, bool isFemale, uint avatarId = 0U)
		{
		}

		// Token: 0x06005668 RID: 22120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005668")]
		[Address(RVA = "0x1B17540", Offset = "0x1B17540", VA = "0x7BBC317540", Slot = "31")]
		internal virtual void SetAvatar(uint avatarId)
		{
		}

		// Token: 0x06005669 RID: 22121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005669")]
		[Address(RVA = "0x1B17640", Offset = "0x1B17640", VA = "0x7BBC317640", Slot = "32")]
		protected virtual void OnSetAvatar(CSSharedAvatarData aData)
		{
		}

		// Token: 0x0600566A RID: 22122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600566A")]
		[Address(RVA = "0x1B179C4", Offset = "0x1B179C4", VA = "0x7BBC3179C4", Slot = "24")]
		protected override void CharacterUpdateCallBack(UMAData data)
		{
		}

		// Token: 0x0600566B RID: 22123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600566B")]
		[Address(RVA = "0x1B179E8", Offset = "0x1B179E8", VA = "0x7BBC3179E8", Slot = "33")]
		protected virtual void OnSetAvatarDone(CSSharedAvatarData aData)
		{
		}

		// Token: 0x0600566C RID: 22124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600566C")]
		[Address(RVA = "0x1B17734", Offset = "0x1B17734", VA = "0x7BBC317734")]
		protected void UpdateFaceSlots(CSSharedAvatarData aData)
		{
		}

		// Token: 0x0600566D RID: 22125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600566D")]
		[Address(RVA = "0x1B17AE8", Offset = "0x1B17AE8", VA = "0x7BBC317AE8")]
		public void PlayLevelUpVfx()
		{
		}

		// Token: 0x0600566E RID: 22126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600566E")]
		[Address(RVA = "0x1B17B90", Offset = "0x1B17B90", VA = "0x7BBC317B90")]
		public void UpdateLobbyBackPackSlot(uint backpackid, uint level)
		{
		}

		// Token: 0x0600566F RID: 22127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600566F")]
		[Address(RVA = "0x1B18114", Offset = "0x1B18114", VA = "0x7BBC318114")]
		public void ClearLobbyAnimEffect()
		{
		}

		// Token: 0x06005670 RID: 22128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005670")]
		[Address(RVA = "0x1B181B0", Offset = "0x1B181B0", VA = "0x7BBC3181B0")]
		public void ClearBackpack()
		{
		}

		// Token: 0x06005671 RID: 22129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005671")]
		[Address(RVA = "0x1B180B8", Offset = "0x1B180B8", VA = "0x7BBC3180B8")]
		public void ClearBackPackSlot()
		{
		}

		// Token: 0x06005672 RID: 22130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005672")]
		[Address(RVA = "0x1B18278", Offset = "0x1B18278", VA = "0x7BBC318278")]
		internal void SetColor(float f)
		{
		}

		// Token: 0x06005673 RID: 22131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005673")]
		[Address(RVA = "0x1B1798C", Offset = "0x1B1798C", VA = "0x7BBC31798C")]
		protected void SetDefaultColor(CSSharedAvatarData aData)
		{
		}

		// Token: 0x06005674 RID: 22132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005674")]
		[Address(RVA = "0x1B184B0", Offset = "0x1B184B0", VA = "0x7BBC3184B0", Slot = "34")]
		public virtual void ResetAvatar()
		{
		}

		// Token: 0x06005675 RID: 22133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005675")]
		[Address(RVA = "0x1B184B8", Offset = "0x1B184B8", VA = "0x7BBC3184B8")]
		public UIAvatar()
		{
		}

		// Token: 0x04007B0D RID: 31501
		[Token(Token = "0x4007B0D")]
		[FieldOffset(Offset = "0x60")]
		protected uint m_AvatarID;

		// Token: 0x04007B0E RID: 31502
		[Token(Token = "0x4007B0E")]
		[FieldOffset(Offset = "0x64")]
		protected bool m_IsCurrentModelFemale;

		// Token: 0x04007B0F RID: 31503
		[Token(Token = "0x4007B0F")]
		[FieldOffset(Offset = "0x65")]
		protected bool m_IsSettingAvatar;

		// Token: 0x04007B10 RID: 31504
		[Token(Token = "0x4007B10")]
		[FieldOffset(Offset = "0x68")]
		protected CSSharedAvatarData m_SettingAvatarData;

		// Token: 0x04007B11 RID: 31505
		[Token(Token = "0x4007B11")]
		[FieldOffset(Offset = "0x70")]
		protected Coroutine m_PlayGunCoroutine;

		// Token: 0x04007B12 RID: 31506
		[Token(Token = "0x4007B12")]
		[FieldOffset(Offset = "0x78")]
		protected Coroutine m_PlayGunAnimCoroutine;

		// Token: 0x04007B13 RID: 31507
		[Token(Token = "0x4007B13")]
		[FieldOffset(Offset = "0x80")]
		protected Coroutine m_PlayGunResetAnimCoroutine;

		// Token: 0x04007B14 RID: 31508
		[Token(Token = "0x4007B14")]
		[FieldOffset(Offset = "0x88")]
		protected GameObject m_backpack;
	}
}
