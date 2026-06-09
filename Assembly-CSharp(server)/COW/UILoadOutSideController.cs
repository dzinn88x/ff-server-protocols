using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x020020AD RID: 8365
	[Token(Token = "0x20020AD")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FDDC4", Offset = "0x10FDDC4")]
	public class UILoadOutSideController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x17000CCA RID: 3274
		// (set) Token: 0x0600BC43 RID: 48195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CCA")]
		public MapModeData SelectedMapData
		{
			[Token(Token = "0x600BC43")]
			[Address(RVA = "0x1CC4B88", Offset = "0x1CC4B88", VA = "0x7BBC4C4B88")]
			set
			{
			}
		}

		// Token: 0x0600BC44 RID: 48196 RVA: 0x00035358 File Offset: 0x00033558
		[Token(Token = "0x600BC44")]
		[Address(RVA = "0x1CC4C00", Offset = "0x1CC4C00", VA = "0x7BBC4C4C00")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600BC45 RID: 48197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC45")]
		[Address(RVA = "0x1CC4C50", Offset = "0x1CC4C50", VA = "0x7BBC4C4C50", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600BC46 RID: 48198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC46")]
		[Address(RVA = "0x1CC5914", Offset = "0x1CC5914", VA = "0x7BBC4C5914", Slot = "20")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0600BC47 RID: 48199 RVA: 0x00035370 File Offset: 0x00033570
		[Token(Token = "0x600BC47")]
		[Address(RVA = "0x1CC5C64", Offset = "0x1CC5C64", VA = "0x7BBC4C5C64", Slot = "34")]
		protected override bool UseCustomizedAnimation()
		{
			return default(bool);
		}

		// Token: 0x0600BC48 RID: 48200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC48")]
		[Address(RVA = "0x1CC4B90", Offset = "0x1CC4B90", VA = "0x7BBC4C4B90")]
		private void UpdateLoadoutAvailableStatus()
		{
		}

		// Token: 0x0600BC49 RID: 48201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC49")]
		[Address(RVA = "0x1CC5C6C", Offset = "0x1CC5C6C", VA = "0x7BBC4C5C6C")]
		private void SetBannedStatus(bool isShow)
		{
		}

		// Token: 0x0600BC4A RID: 48202 RVA: 0x00035388 File Offset: 0x00033588
		[Token(Token = "0x600BC4A")]
		[Address(RVA = "0x1CC5F8C", Offset = "0x1CC5F8C", VA = "0x7BBC4C5F8C")]
		private bool IsLoadoutEnable(uint gameMode)
		{
			return default(bool);
		}

		// Token: 0x0600BC4B RID: 48203 RVA: 0x000353A0 File Offset: 0x000335A0
		[Token(Token = "0x600BC4B")]
		[Address(RVA = "0x1CC6070", Offset = "0x1CC6070", VA = "0x7BBC4C6070")]
		private bool IsSelectedSpeedMode()
		{
			return default(bool);
		}

		// Token: 0x0600BC4C RID: 48204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC4C")]
		[Address(RVA = "0x1CC5570", Offset = "0x1CC5570", VA = "0x7BBC4C5570")]
		private void InitContents()
		{
		}

		// Token: 0x0600BC4D RID: 48205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BC4D")]
		[Address(RVA = "0x1CC609C", Offset = "0x1CC609C", VA = "0x7BBC4C609C")]
		private List<Item> FilterLoadouts(List<Item> loadoutList)
		{
			return null;
		}

		// Token: 0x0600BC4E RID: 48206 RVA: 0x000353B8 File Offset: 0x000335B8
		[Token(Token = "0x600BC4E")]
		[Address(RVA = "0x1CC67E8", Offset = "0x1CC67E8", VA = "0x7BBC4C67E8")]
		private bool IsItemShow(Item item)
		{
			return default(bool);
		}

		// Token: 0x0600BC4F RID: 48207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC4F")]
		[Address(RVA = "0x1CC61AC", Offset = "0x1CC61AC", VA = "0x7BBC4C61AC")]
		private void BuildLoadoutsUI(List<Item> loadoutList, CSSharedItemDataManager.LoadoutSubType type, UIGrid grid)
		{
		}

		// Token: 0x0600BC50 RID: 48208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC50")]
		[Address(RVA = "0x1CC5218", Offset = "0x1CC5218", VA = "0x7BBC4C5218")]
		private void InitSkillContent()
		{
		}

		// Token: 0x0600BC51 RID: 48209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC51")]
		[Address(RVA = "0x1CC56A0", Offset = "0x1CC56A0", VA = "0x7BBC4C56A0")]
		private void RefreshAvatarProfileAndSuit()
		{
		}

		// Token: 0x0600BC52 RID: 48210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC52")]
		[Address(RVA = "0x1CC69E0", Offset = "0x1CC69E0", VA = "0x7BBC4C69E0")]
		public void RefreshData()
		{
		}

		// Token: 0x0600BC53 RID: 48211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC53")]
		[Address(RVA = "0x1CC6BB0", Offset = "0x1CC6BB0", VA = "0x7BBC4C6BB0")]
		private void OnOpenSkillList(object[] data)
		{
		}

		// Token: 0x0600BC54 RID: 48212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC54")]
		[Address(RVA = "0x1CC6D58", Offset = "0x1CC6D58", VA = "0x7BBC4C6D58")]
		private void OnEquipSkill(object[] data)
		{
		}

		// Token: 0x0600BC55 RID: 48213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC55")]
		[Address(RVA = "0x1CC6E38", Offset = "0x1CC6E38", VA = "0x7BBC4C6E38", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x0600BC56 RID: 48214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC56")]
		[Address(RVA = "0x1CC7914", Offset = "0x1CC7914", VA = "0x7BBC4C7914")]
		private void OnLoadoutOriginalSet(params object[] data)
		{
		}

		// Token: 0x0600BC57 RID: 48215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC57")]
		[Address(RVA = "0x1CC79D8", Offset = "0x1CC79D8", VA = "0x7BBC4C79D8")]
		private void OnUILoadOutSelected(params object[] data)
		{
		}

		// Token: 0x0600BC58 RID: 48216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC58")]
		[Address(RVA = "0x1CC7BD4", Offset = "0x1CC7BD4", VA = "0x7BBC4C7BD4")]
		private void OnSurvivalInfoBtnClick()
		{
		}

		// Token: 0x0600BC59 RID: 48217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC59")]
		[Address(RVA = "0x1CC7C98", Offset = "0x1CC7C98", VA = "0x7BBC4C7C98")]
		private void OnBasicInfoBtnClick()
		{
		}

		// Token: 0x0600BC5A RID: 48218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC5A")]
		[Address(RVA = "0x1CC7D5C", Offset = "0x1CC7D5C", VA = "0x7BBC4C7D5C")]
		private void OnCloseClick()
		{
		}

		// Token: 0x0600BC5B RID: 48219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC5B")]
		[Address(RVA = "0x1CC7E4C", Offset = "0x1CC7E4C", VA = "0x7BBC4C7E4C")]
		private void OnSelfSlotClicked(params object[] data)
		{
		}

		// Token: 0x0600BC5C RID: 48220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC5C")]
		[Address(RVA = "0x1CC8044", Offset = "0x1CC8044", VA = "0x7BBC4C8044", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600BC5D RID: 48221 RVA: 0x000353D0 File Offset: 0x000335D0
		[Token(Token = "0x600BC5D")]
		[Address(RVA = "0x1CC8240", Offset = "0x1CC8240", VA = "0x7BBC4C8240", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600BC5E RID: 48222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC5E")]
		[Address(RVA = "0x1CC82FC", Offset = "0x1CC82FC", VA = "0x7BBC4C82FC")]
		public UILoadOutSideController()
		{
		}

		// Token: 0x0400BCDA RID: 48346
		[Token(Token = "0x400BCDA")]
		private const uint LOADOUT_TUTORIAL_SUBTYPE_SURVIVAL = 500000001U;

		// Token: 0x0400BCDB RID: 48347
		[Token(Token = "0x400BCDB")]
		private const uint LOADOUT_TUTORIAL_SUBTYPE_BASIC = 500000002U;

		// Token: 0x0400BCDC RID: 48348
		[Token(Token = "0x400BCDC")]
		private const string LOADOUT_TUTORIAL_TITLE_SURVIVAL = "T_27_C_LOUT_S_INTRO";

		// Token: 0x0400BCDD RID: 48349
		[Token(Token = "0x400BCDD")]
		private const string LOADOUT_TUTORIAL_TITLE_BASIC = "T_27_C_LOUT_B_INTRO";

		// Token: 0x0400BCDE RID: 48350
		[Token(Token = "0x400BCDE")]
		[FieldOffset(Offset = "0x98")]
		private UILoadOutSideView m_View;

		// Token: 0x0400BCDF RID: 48351
		[Token(Token = "0x400BCDF")]
		[FieldOffset(Offset = "0xA0")]
		private Transform[] m_SlotCommonList;

		// Token: 0x0400BCE0 RID: 48352
		[Token(Token = "0x400BCE0")]
		[FieldOffset(Offset = "0xA8")]
		private List<UIAvatarSkillSlotController> m_SlotCommonCtrlList;

		// Token: 0x0400BCE1 RID: 48353
		[Token(Token = "0x400BCE1")]
		[FieldOffset(Offset = "0xB0")]
		private UIChooseSkillWindowController m_ChooseSkillCtrl;

		// Token: 0x0400BCE2 RID: 48354
		[Token(Token = "0x400BCE2")]
		[FieldOffset(Offset = "0xB8")]
		private List<UILoadoutItemControllerUnified> m_LoadOutItemCtrlsOld;

		// Token: 0x0400BCE3 RID: 48355
		[Token(Token = "0x400BCE3")]
		[FieldOffset(Offset = "0xC0")]
		private List<UILoadoutItemControllerUnified> m_LoadOutItemCtrlsNew;

		// Token: 0x0400BCE4 RID: 48356
		[Token(Token = "0x400BCE4")]
		[FieldOffset(Offset = "0xC8")]
		private int m_CurrentSelectedLoadoutId;

		// Token: 0x0400BCE5 RID: 48357
		[Token(Token = "0x400BCE5")]
		[FieldOffset(Offset = "0xCC")]
		private int m_CurrentSelectedLoadoutIdNew;

		// Token: 0x0400BCE6 RID: 48358
		[Token(Token = "0x400BCE6")]
		[FieldOffset(Offset = "0xD0")]
		private uint m_OriginalNewId;

		// Token: 0x0400BCE7 RID: 48359
		[Token(Token = "0x400BCE7")]
		[FieldOffset(Offset = "0xD4")]
		private uint m_OriginalOldId;

		// Token: 0x0400BCE8 RID: 48360
		[Token(Token = "0x400BCE8")]
		[FieldOffset(Offset = "0xD8")]
		private uint m_CurrentShowAvatarID;

		// Token: 0x0400BCE9 RID: 48361
		[Token(Token = "0x400BCE9")]
		[FieldOffset(Offset = "0xE0")]
		private AvatarProfile m_Profile;

		// Token: 0x0400BCEA RID: 48362
		[Token(Token = "0x400BCEA")]
		[FieldOffset(Offset = "0xE8")]
		private MapModeData m_SelectedMapData;

		// Token: 0x0400BCEB RID: 48363
		[Token(Token = "0x400BCEB")]
		[FieldOffset(Offset = "0xF0")]
		private UIModelAvatarProfile m_AvatarProfileModel;

		// Token: 0x0400BCEC RID: 48364
		[Token(Token = "0x400BCEC")]
		[FieldOffset(Offset = "0xF8")]
		private UIModelGroup m_ModelGroup;

		// Token: 0x0400BCED RID: 48365
		[Token(Token = "0x400BCED")]
		[FieldOffset(Offset = "0x100")]
		private UIModelMapOpeningInfo m_ModelMap;

		// Token: 0x0400BCEE RID: 48366
		[Token(Token = "0x400BCEE")]
		[FieldOffset(Offset = "0x108")]
		private AvatarSkillData m_SkillData;
	}
}
