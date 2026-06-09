using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001710 RID: 5904
	[Token(Token = "0x2001710")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F160C", Offset = "0x10F160C")]
	public class UIChooseSkillWindowController : UIPopupWindowController, IEasyList
	{
		// Token: 0x06006E04 RID: 28164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E04")]
		[Address(RVA = "0x1BF55E4", Offset = "0x1BF55E4", VA = "0x7BBC3F55E4", Slot = "28")]
		public override string Rule()
		{
			return null;
		}

		// Token: 0x06006E05 RID: 28165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E05")]
		[Address(RVA = "0x1BF562C", Offset = "0x1BF562C", VA = "0x7BBC3F562C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006E06 RID: 28166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E06")]
		[Address(RVA = "0x1BF5AC0", Offset = "0x1BF5AC0", VA = "0x7BBC3F5AC0")]
		private void OnUpdateInfo(params object[] data)
		{
		}

		// Token: 0x06006E07 RID: 28167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E07")]
		[Address(RVA = "0x1BF67CC", Offset = "0x1BF67CC", VA = "0x7BBC3F67CC")]
		private void OnBuyClick()
		{
		}

		// Token: 0x06006E08 RID: 28168 RVA: 0x0001EFC0 File Offset: 0x0001D1C0
		[Token(Token = "0x6006E08")]
		[Address(RVA = "0x1BF6A14", Offset = "0x1BF6A14", VA = "0x7BBC3F6A14")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006E09 RID: 28169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E09")]
		[Address(RVA = "0x1BF6A64", Offset = "0x1BF6A64", VA = "0x7BBC3F6A64", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006E0A RID: 28170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E0A")]
		[Address(RVA = "0x1BF6C1C", Offset = "0x1BF6C1C", VA = "0x7BBC3F6C1C")]
		public void SetData(uint currentShowAvatarid, int slotindex)
		{
		}

		// Token: 0x06006E0B RID: 28171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E0B")]
		[Address(RVA = "0x1BF7060", Offset = "0x1BF7060", VA = "0x7BBC3F7060")]
		private void OnHideBtnClick()
		{
		}

		// Token: 0x06006E0C RID: 28172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E0C")]
		[Address(RVA = "0x1BF7114", Offset = "0x1BF7114", VA = "0x7BBC3F7114")]
		private void OnSkillEquip(params object[] data)
		{
		}

		// Token: 0x06006E0D RID: 28173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E0D")]
		[Address(RVA = "0x1BF711C", Offset = "0x1BF711C", VA = "0x7BBC3F711C")]
		private void OnUpdateTips(params object[] data)
		{
		}

		// Token: 0x06006E0E RID: 28174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E0E")]
		[Address(RVA = "0x1BF7124", Offset = "0x1BF7124", VA = "0x7BBC3F7124")]
		public void Refresh()
		{
		}

		// Token: 0x06006E0F RID: 28175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E0F")]
		[Address(RVA = "0x1BF73D8", Offset = "0x1BF73D8", VA = "0x7BBC3F73D8")]
		public Transform GetTipsTr()
		{
			return null;
		}

		// Token: 0x06006E10 RID: 28176 RVA: 0x0001EFD8 File Offset: 0x0001D1D8
		[Token(Token = "0x6006E10")]
		[Address(RVA = "0x1BF7404", Offset = "0x1BF7404", VA = "0x7BBC3F7404")]
		public int GetDepth()
		{
			return 0;
		}

		// Token: 0x06006E11 RID: 28177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E11")]
		[Address(RVA = "0x1BF5A3C", Offset = "0x1BF5A3C", VA = "0x7BBC3F5A3C")]
		public void RefreshOpenState(bool flag)
		{
		}

		// Token: 0x06006E12 RID: 28178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E12")]
		[Address(RVA = "0x1BF7444", Offset = "0x1BF7444", VA = "0x7BBC3F7444", Slot = "40")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06006E13 RID: 28179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E13")]
		[Address(RVA = "0x1BF74D8", Offset = "0x1BF74D8", VA = "0x7BBC3F74D8", Slot = "41")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06006E14 RID: 28180 RVA: 0x0001EFF0 File Offset: 0x0001D1F0
		[Token(Token = "0x6006E14")]
		[Address(RVA = "0x1BF7508", Offset = "0x1BF7508", VA = "0x7BBC3F7508")]
		private int GetSkillColor(char color)
		{
			return 0;
		}

		// Token: 0x06006E15 RID: 28181 RVA: 0x0001F008 File Offset: 0x0001D208
		[Token(Token = "0x6006E15")]
		[Address(RVA = "0x1BF7550", Offset = "0x1BF7550", VA = "0x7BBC3F7550")]
		private int SkillCompare(SkillInfo a, SkillInfo b)
		{
			return 0;
		}

		// Token: 0x06006E16 RID: 28182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E16")]
		[Address(RVA = "0x1BF6DF0", Offset = "0x1BF6DF0", VA = "0x7BBC3F6DF0")]
		private void CreateLeaderBoardMenu()
		{
		}

		// Token: 0x06006E17 RID: 28183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E17")]
		[Address(RVA = "0x1BF5B5C", Offset = "0x1BF5B5C", VA = "0x7BBC3F5B5C")]
		private void OnPositiveMenuSelected()
		{
		}

		// Token: 0x06006E18 RID: 28184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E18")]
		[Address(RVA = "0x1BF5DB8", Offset = "0x1BF5DB8", VA = "0x7BBC3F5DB8")]
		private void OnActiveMenuSelected()
		{
		}

		// Token: 0x06006E19 RID: 28185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E19")]
		[Address(RVA = "0x1BF75DC", Offset = "0x1BF75DC", VA = "0x7BBC3F75DC")]
		private void GetSkillList(bool isActiveSkill)
		{
		}

		// Token: 0x06006E1A RID: 28186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E1A")]
		[Address(RVA = "0x1BF7C78", Offset = "0x1BF7C78", VA = "0x7BBC3F7C78")]
		private void FinishSkillGuide()
		{
		}

		// Token: 0x06006E1B RID: 28187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E1B")]
		[Address(RVA = "0x1BF7C7C", Offset = "0x1BF7C7C", VA = "0x7BBC3F7C7C")]
		public UIChooseSkillWindowController()
		{
		}

		// Token: 0x040088D6 RID: 35030
		[Token(Token = "0x40088D6")]
		[FieldOffset(Offset = "0x98")]
		private List<SkillInfo> m_SkillList;

		// Token: 0x040088D7 RID: 35031
		[Token(Token = "0x40088D7")]
		[FieldOffset(Offset = "0xA0")]
		private UIChooseSkillWindowView m_View;

		// Token: 0x040088D8 RID: 35032
		[Token(Token = "0x40088D8")]
		[FieldOffset(Offset = "0xA8")]
		private int m_SlotIndex;

		// Token: 0x040088D9 RID: 35033
		[Token(Token = "0x40088D9")]
		[FieldOffset(Offset = "0xAC")]
		private uint m_CurrentShowAvatarid;

		// Token: 0x040088DA RID: 35034
		[Token(Token = "0x40088DA")]
		[FieldOffset(Offset = "0xB0")]
		public bool m_ChooseSkillMenuCreated;

		// Token: 0x040088DB RID: 35035
		[Token(Token = "0x40088DB")]
		[FieldOffset(Offset = "0xB8")]
		private string m_DeepLink;

		// Token: 0x040088DC RID: 35036
		[Token(Token = "0x40088DC")]
		private const string DL_Positive = "Positive";

		// Token: 0x040088DD RID: 35037
		[Token(Token = "0x40088DD")]
		private const string DL_Active = "Active";

		// Token: 0x040088DE RID: 35038
		[Token(Token = "0x40088DE")]
		private const string AVATAR_SKILL_CHOOSE_ACTIVE = "AVATAR_SKILL_CHOOSE_ACTIVE";

		// Token: 0x040088DF RID: 35039
		[Token(Token = "0x40088DF")]
		[FieldOffset(Offset = "0xC0")]
		private UICommonGuideController m_GuideCtrl;

		// Token: 0x040088E0 RID: 35040
		[Token(Token = "0x40088E0")]
		[FieldOffset(Offset = "0xC8")]
		private UIAvatarSkillSlotController slotctrl;

		// Token: 0x02001711 RID: 5905
		[Token(Token = "0x2001711")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F1644", Offset = "0x10F1644")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06006E1D RID: 28189 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006E1D")]
			[Address(RVA = "0x1BF7D50", Offset = "0x1BF7D50", VA = "0x7BBC3F7D50")]
			public <>c()
			{
			}

			// Token: 0x06006E1E RID: 28190 RVA: 0x0001F020 File Offset: 0x0001D220
			[Token(Token = "0x6006E1E")]
			[Address(RVA = "0x1BF7D58", Offset = "0x1BF7D58", VA = "0x7BBC3F7D58")]
			internal bool <OnActiveMenuSelected>b__31_0(AvatarProfile a)
			{
				return default(bool);
			}

			// Token: 0x040088E1 RID: 35041
			[Token(Token = "0x40088E1")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIChooseSkillWindowController.<>c <>9;

			// Token: 0x040088E2 RID: 35042
			[Token(Token = "0x40088E2")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<AvatarProfile> <>9__31_0;
		}
	}
}
