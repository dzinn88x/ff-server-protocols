using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020025B0 RID: 9648
	[Token(Token = "0x20025B0")]
	public class UIAvatarSkillSlotMono : MonoBehaviour
	{
		// Token: 0x0600C685 RID: 50821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C685")]
		[Address(RVA = "0x1E4D9A8", Offset = "0x1E4D9A8", VA = "0x7BBC64D9A8")]
		protected void Awake()
		{
		}

		// Token: 0x0600C686 RID: 50822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C686")]
		[Address(RVA = "0x1E4DC0C", Offset = "0x1E4DC0C", VA = "0x7BBC64DC0C")]
		protected void OnDestroy()
		{
		}

		// Token: 0x0600C687 RID: 50823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C687")]
		[Address(RVA = "0x1E4DE1C", Offset = "0x1E4DE1C", VA = "0x7BBC64DE1C")]
		public void SetData(uint skillID, int slotindex, bool isLocked, uint avatarid, bool isUnReachLv = false)
		{
		}

		// Token: 0x0600C688 RID: 50824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C688")]
		[Address(RVA = "0x1E4E790", Offset = "0x1E4E790", VA = "0x7BBC64E790")]
		private void OnUpdateRedTips(params object[] data)
		{
		}

		// Token: 0x0600C689 RID: 50825 RVA: 0x000354A8 File Offset: 0x000336A8
		[Token(Token = "0x600C689")]
		[Address(RVA = "0x1E4E71C", Offset = "0x1E4E71C", VA = "0x7BBC64E71C")]
		private bool CheckHasTips(AvatarProfile profile)
		{
			return default(bool);
		}

		// Token: 0x0600C68A RID: 50826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C68A")]
		[Address(RVA = "0x1E4E580", Offset = "0x1E4E580", VA = "0x7BBC64E580")]
		private void SetBgColor(char type)
		{
		}

		// Token: 0x0600C68B RID: 50827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C68B")]
		[Address(RVA = "0x1E4E8CC", Offset = "0x1E4E8CC", VA = "0x7BBC64E8CC")]
		private void OnSkillWindowClose(object[] data)
		{
		}

		// Token: 0x0600C68C RID: 50828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C68C")]
		[Address(RVA = "0x1E4E988", Offset = "0x1E4E988", VA = "0x7BBC64E988")]
		private void OnUnlockSkillSlot(object[] data)
		{
		}

		// Token: 0x0600C68D RID: 50829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C68D")]
		[Address(RVA = "0x1E4EB34", Offset = "0x1E4EB34", VA = "0x7BBC64EB34")]
		public void DisableSlotBtn()
		{
		}

		// Token: 0x0600C68E RID: 50830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C68E")]
		[Address(RVA = "0x1E4EBA8", Offset = "0x1E4EBA8", VA = "0x7BBC64EBA8")]
		public void HideAllLvBg()
		{
		}

		// Token: 0x0600C68F RID: 50831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C68F")]
		[Address(RVA = "0x1E4EC00", Offset = "0x1E4EC00", VA = "0x7BBC64EC00")]
		public void OnWindowCover(object[] data)
		{
		}

		// Token: 0x0600C690 RID: 50832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C690")]
		[Address(RVA = "0x1E4EE44", Offset = "0x1E4EE44", VA = "0x7BBC64EE44")]
		public UIAvatarSkillSlotMono()
		{
		}

		// Token: 0x0400F90F RID: 63759
		[Token(Token = "0x400F90F")]
		[FieldOffset(Offset = "0x18")]
		private uint m_AvatarID;

		// Token: 0x0400F910 RID: 63760
		[Token(Token = "0x400F910")]
		[FieldOffset(Offset = "0x1C")]
		private int m_SlotIndex;

		// Token: 0x0400F911 RID: 63761
		[Token(Token = "0x400F911")]
		[FieldOffset(Offset = "0x20")]
		private bool m_IsLocked;

		// Token: 0x0400F912 RID: 63762
		[Token(Token = "0x400F912")]
		[FieldOffset(Offset = "0x21")]
		private bool m_IsEquip;

		// Token: 0x0400F913 RID: 63763
		[Token(Token = "0x400F913")]
		[FieldOffset(Offset = "0x22")]
		private bool canUnLock;

		// Token: 0x0400F914 RID: 63764
		[Token(Token = "0x400F914")]
		[FieldOffset(Offset = "0x28")]
		public AvatarSelectionSkillSlot SlotScript;

		// Token: 0x0400F915 RID: 63765
		[Token(Token = "0x400F915")]
		[FieldOffset(Offset = "0x30")]
		public UIButton SlotBtn;

		// Token: 0x0400F916 RID: 63766
		[Token(Token = "0x400F916")]
		[FieldOffset(Offset = "0x38")]
		public GameObject SelectedHL;

		// Token: 0x0400F917 RID: 63767
		[Token(Token = "0x400F917")]
		[FieldOffset(Offset = "0x40")]
		public GameObject NormalBG_G;

		// Token: 0x0400F918 RID: 63768
		[Token(Token = "0x400F918")]
		[FieldOffset(Offset = "0x48")]
		public GameObject NormalBG_Y;

		// Token: 0x0400F919 RID: 63769
		[Token(Token = "0x400F919")]
		[FieldOffset(Offset = "0x50")]
		public GameObject NormalBG_R;

		// Token: 0x0400F91A RID: 63770
		[Token(Token = "0x400F91A")]
		[FieldOffset(Offset = "0x58")]
		public GameObject NormalBG_N;

		// Token: 0x0400F91B RID: 63771
		[Token(Token = "0x400F91B")]
		[FieldOffset(Offset = "0x60")]
		public GameObject lv_bg;

		// Token: 0x0400F91C RID: 63772
		[Token(Token = "0x400F91C")]
		[FieldOffset(Offset = "0x68")]
		public UILabel LvLabel;

		// Token: 0x0400F91D RID: 63773
		[Token(Token = "0x400F91D")]
		[FieldOffset(Offset = "0x70")]
		public GameObject lv_bg2;

		// Token: 0x0400F91E RID: 63774
		[Token(Token = "0x400F91E")]
		[FieldOffset(Offset = "0x78")]
		public UILabel LvLabel2;

		// Token: 0x0400F91F RID: 63775
		[Token(Token = "0x400F91F")]
		[FieldOffset(Offset = "0x80")]
		public GameObject Empty;

		// Token: 0x0400F920 RID: 63776
		[Token(Token = "0x400F920")]
		[FieldOffset(Offset = "0x88")]
		public GameObject LockGo;

		// Token: 0x0400F921 RID: 63777
		[Token(Token = "0x400F921")]
		[FieldOffset(Offset = "0x90")]
		public GameObject lockSprite;

		// Token: 0x0400F922 RID: 63778
		[Token(Token = "0x400F922")]
		[FieldOffset(Offset = "0x98")]
		public GameObject unlockAnim;

		// Token: 0x0400F923 RID: 63779
		[Token(Token = "0x400F923")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject newSlotTip;

		// Token: 0x0400F924 RID: 63780
		[Token(Token = "0x400F924")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject ActiveSkillLock;

		// Token: 0x0400F925 RID: 63781
		[Token(Token = "0x400F925")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject RedTips;

		// Token: 0x0400F926 RID: 63782
		[Token(Token = "0x400F926")]
		[FieldOffset(Offset = "0xB8")]
		private UIModelAvatarProfile m_Model;

		// Token: 0x0400F927 RID: 63783
		[Token(Token = "0x400F927")]
		[FieldOffset(Offset = "0xC0")]
		private AvatarProfile avatarProfile;

		// Token: 0x0400F928 RID: 63784
		[Token(Token = "0x400F928")]
		private const string m_FixedSkillTipKey = "TXT_PROFILE_FIXEDSKILL_TIP";

		// Token: 0x0400F929 RID: 63785
		[Token(Token = "0x400F929")]
		private const string m_UnLockPreSlotTipKey = "TXT_OB8_JRW_NEED_TO_UNLOCK_PRESLOT_TIP";

		// Token: 0x0400F92A RID: 63786
		[Token(Token = "0x400F92A")]
		private const string m_OpenNewSlotTipKey = "OPEN_NEW_SLOT_TIP";

		// Token: 0x0400F92B RID: 63787
		[Token(Token = "0x400F92B")]
		[FieldOffset(Offset = "0xC8")]
		private uint m_DelayCallID;

		// Token: 0x0400F92C RID: 63788
		[Token(Token = "0x400F92C")]
		[FieldOffset(Offset = "0xD0")]
		private AvatarSkillData m_Skilldata;
	}
}
