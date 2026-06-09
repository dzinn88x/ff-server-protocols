using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x0200169E RID: 5790
	[Token(Token = "0x200169E")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F072C", Offset = "0x10F072C")]
	public class UIAddFriendController : UIBaseController, IUIModelDataChangeObserver, IEasyList
	{
		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x06006955 RID: 26965 RVA: 0x0001DCE8 File Offset: 0x0001BEE8
		// (set) Token: 0x06006956 RID: 26966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000914")]
		public uint RefreshState
		{
			[Token(Token = "0x6006955")]
			[Address(RVA = "0x1963EB4", Offset = "0x1963EB4", VA = "0x7BBC163EB4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1140C20", Offset = "0x1140C20")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6006956")]
			[Address(RVA = "0x1963EBC", Offset = "0x1963EBC", VA = "0x7BBC163EBC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1140C30", Offset = "0x1140C30")]
			private set
			{
			}
		}

		// Token: 0x06006957 RID: 26967 RVA: 0x0001DD00 File Offset: 0x0001BF00
		[Token(Token = "0x6006957")]
		[Address(RVA = "0x1963EC4", Offset = "0x1963EC4", VA = "0x7BBC163EC4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x06006958 RID: 26968 RVA: 0x0001DD18 File Offset: 0x0001BF18
		[Token(Token = "0x17000915")]
		public EFriendTabType CurrentTabType
		{
			[Token(Token = "0x6006958")]
			[Address(RVA = "0x1963F14", Offset = "0x1963F14", VA = "0x7BBC163F14")]
			get
			{
				return EFriendTabType.eFriend;
			}
		}

		// Token: 0x06006959 RID: 26969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006959")]
		[Address(RVA = "0x1963F1C", Offset = "0x1963F1C", VA = "0x7BBC163F1C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600695A RID: 26970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600695A")]
		[Address(RVA = "0x1964ED0", Offset = "0x1964ED0", VA = "0x7BBC164ED0", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600695B RID: 26971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600695B")]
		[Address(RVA = "0x1964674", Offset = "0x1964674", VA = "0x7BBC164674")]
		private void InitPopMenus()
		{
		}

		// Token: 0x0600695C RID: 26972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600695C")]
		[Address(RVA = "0x1964F84", Offset = "0x1964F84", VA = "0x7BBC164F84")]
		public void SetViewData(int width)
		{
		}

		// Token: 0x0600695D RID: 26973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600695D")]
		[Address(RVA = "0x19650EC", Offset = "0x19650EC", VA = "0x7BBC1650EC")]
		private void OnSearchBtnClick()
		{
		}

		// Token: 0x0600695E RID: 26974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600695E")]
		[Address(RVA = "0x1965438", Offset = "0x1965438", VA = "0x7BBC165438")]
		private void OnInputSubmit()
		{
		}

		// Token: 0x0600695F RID: 26975 RVA: 0x0001DD30 File Offset: 0x0001BF30
		[Token(Token = "0x600695F")]
		[Address(RVA = "0x19653FC", Offset = "0x19653FC", VA = "0x7BBC1653FC")]
		public bool IsDefaultSearch()
		{
			return default(bool);
		}

		// Token: 0x06006960 RID: 26976 RVA: 0x0001DD48 File Offset: 0x0001BF48
		[Token(Token = "0x6006960")]
		[Address(RVA = "0x1965778", Offset = "0x1965778", VA = "0x7BBC165778")]
		public bool IsLanguageDefault()
		{
			return default(bool);
		}

		// Token: 0x06006961 RID: 26977 RVA: 0x0001DD60 File Offset: 0x0001BF60
		[Token(Token = "0x6006961")]
		[Address(RVA = "0x1965788", Offset = "0x1965788", VA = "0x7BBC165788")]
		public bool IsModePreferDefault()
		{
			return default(bool);
		}

		// Token: 0x06006962 RID: 26978 RVA: 0x0001DD78 File Offset: 0x0001BF78
		[Token(Token = "0x6006962")]
		[Address(RVA = "0x1965798", Offset = "0x1965798", VA = "0x7BBC165798")]
		public bool isTimeActiveDefault()
		{
			return default(bool);
		}

		// Token: 0x06006963 RID: 26979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006963")]
		[Address(RVA = "0x19657A8", Offset = "0x19657A8", VA = "0x7BBC1657A8")]
		private void OnRefreshBtnClick()
		{
		}

		// Token: 0x06006964 RID: 26980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006964")]
		[Address(RVA = "0x1965C84", Offset = "0x1965C84", VA = "0x7BBC165C84")]
		public void OnRefreshSelectBtnClick()
		{
		}

		// Token: 0x06006965 RID: 26981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006965")]
		[Address(RVA = "0x1966224", Offset = "0x1966224", VA = "0x7BBC166224")]
		private void OnLanguageBtnClick()
		{
		}

		// Token: 0x06006966 RID: 26982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006966")]
		[Address(RVA = "0x19666B4", Offset = "0x19666B4", VA = "0x7BBC1666B4")]
		private void OnSearchInputChange()
		{
		}

		// Token: 0x06006967 RID: 26983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006967")]
		[Address(RVA = "0x1966794", Offset = "0x1966794", VA = "0x7BBC166794")]
		private void OnClearButtonClicked()
		{
		}

		// Token: 0x06006968 RID: 26984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006968")]
		[Address(RVA = "0x1966B44", Offset = "0x1966B44", VA = "0x7BBC166B44")]
		private void OnSearchInputGetFocus()
		{
		}

		// Token: 0x06006969 RID: 26985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006969")]
		[Address(RVA = "0x1966BB0", Offset = "0x1966BB0", VA = "0x7BBC166BB0", Slot = "30")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x0600696A RID: 26986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600696A")]
		[Address(RVA = "0x1966C6C", Offset = "0x1966C6C", VA = "0x7BBC166C6C", Slot = "31")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x0600696B RID: 26987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600696B")]
		[Address(RVA = "0x1966C9C", Offset = "0x1966C9C", VA = "0x7BBC166C9C", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600696C RID: 26988 RVA: 0x0001DD90 File Offset: 0x0001BF90
		[Token(Token = "0x600696C")]
		[Address(RVA = "0x19672BC", Offset = "0x19672BC", VA = "0x7BBC1672BC", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600696D RID: 26989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600696D")]
		[Address(RVA = "0x1967040", Offset = "0x1967040", VA = "0x7BBC167040")]
		private void RefreshList(List<FriendAccountInfo> accountList, bool keep_page = false)
		{
		}

		// Token: 0x0600696E RID: 26990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600696E")]
		[Address(RVA = "0x1966424", Offset = "0x1966424", VA = "0x7BBC166424")]
		private void InitLanguageList()
		{
		}

		// Token: 0x0600696F RID: 26991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600696F")]
		[Address(RVA = "0x1967300", Offset = "0x1967300", VA = "0x7BBC167300")]
		private void GenerateGenderMenuData()
		{
		}

		// Token: 0x06006970 RID: 26992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006970")]
		[Address(RVA = "0x19675FC", Offset = "0x19675FC", VA = "0x7BBC1675FC")]
		private void GenerateTimeActiveMenuData()
		{
		}

		// Token: 0x06006971 RID: 26993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006971")]
		[Address(RVA = "0x1967914", Offset = "0x1967914", VA = "0x7BBC167914")]
		private void GenerateModePreferMenuData()
		{
		}

		// Token: 0x06006972 RID: 26994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006972")]
		[Address(RVA = "0x1967C2C", Offset = "0x1967C2C", VA = "0x7BBC167C2C")]
		private void OnGenderSelected(object obj)
		{
		}

		// Token: 0x06006973 RID: 26995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006973")]
		[Address(RVA = "0x1967E4C", Offset = "0x1967E4C", VA = "0x7BBC167E4C")]
		private void OnTimeActiveSelected(object obj)
		{
		}

		// Token: 0x06006974 RID: 26996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006974")]
		[Address(RVA = "0x196806C", Offset = "0x196806C", VA = "0x7BBC16806C")]
		private void OnModeHobbySelected(object obj)
		{
		}

		// Token: 0x06006975 RID: 26997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006975")]
		[Address(RVA = "0x196828C", Offset = "0x196828C", VA = "0x7BBC16828C")]
		private void OnLocLanguageSelect(object obj)
		{
		}

		// Token: 0x06006976 RID: 26998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006976")]
		[Address(RVA = "0x1968528", Offset = "0x1968528", VA = "0x7BBC168528")]
		public UIAddFriendController()
		{
		}

		// Token: 0x06006977 RID: 26999 RVA: 0x0001DDA8 File Offset: 0x0001BFA8
		[Token(Token = "0x6006977")]
		[Address(RVA = "0x1968604", Offset = "0x1968604", VA = "0x7BBC168604")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1140C40", Offset = "0x1140C40")]
		private bool <InitPopMenus>b__26_0(PlayerSocialTagsData x)
		{
			return default(bool);
		}

		// Token: 0x06006978 RID: 27000 RVA: 0x0001DDC0 File Offset: 0x0001BFC0
		[Token(Token = "0x6006978")]
		[Address(RVA = "0x1968640", Offset = "0x1968640", VA = "0x7BBC168640")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1140C50", Offset = "0x1140C50")]
		private bool <InitPopMenus>b__26_1(PlayerSocialTagsData x)
		{
			return default(bool);
		}

		// Token: 0x06006979 RID: 27001 RVA: 0x0001DDD8 File Offset: 0x0001BFD8
		[Token(Token = "0x6006979")]
		[Address(RVA = "0x196867C", Offset = "0x196867C", VA = "0x7BBC16867C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1140C60", Offset = "0x1140C60")]
		private bool <InitPopMenus>b__26_2(PlayerSocialTagsData x)
		{
			return default(bool);
		}

		// Token: 0x0600697A RID: 27002 RVA: 0x0001DDF0 File Offset: 0x0001BFF0
		[Token(Token = "0x600697A")]
		[Address(RVA = "0x19686B8", Offset = "0x19686B8", VA = "0x7BBC1686B8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1140C70", Offset = "0x1140C70")]
		private bool <OnRefreshSelectBtnClick>b__35_0(PlayerSocialTagsData x)
		{
			return default(bool);
		}

		// Token: 0x0600697B RID: 27003 RVA: 0x0001DE08 File Offset: 0x0001C008
		[Token(Token = "0x600697B")]
		[Address(RVA = "0x19686F4", Offset = "0x19686F4", VA = "0x7BBC1686F4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1140C80", Offset = "0x1140C80")]
		private bool <OnRefreshSelectBtnClick>b__35_1(PlayerSocialTagsData x)
		{
			return default(bool);
		}

		// Token: 0x0600697C RID: 27004 RVA: 0x0001DE20 File Offset: 0x0001C020
		[Token(Token = "0x600697C")]
		[Address(RVA = "0x1968730", Offset = "0x1968730", VA = "0x7BBC168730")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1140C90", Offset = "0x1140C90")]
		private bool <OnRefreshSelectBtnClick>b__35_2(PlayerSocialTagsData x)
		{
			return default(bool);
		}

		// Token: 0x0600697D RID: 27005 RVA: 0x0001DE38 File Offset: 0x0001C038
		[Token(Token = "0x600697D")]
		[Address(RVA = "0x196876C", Offset = "0x196876C", VA = "0x7BBC16876C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1140CA0", Offset = "0x1140CA0")]
		private bool <OnGenderSelected>b__49_0(PlayerSocialTagsData x)
		{
			return default(bool);
		}

		// Token: 0x0600697E RID: 27006 RVA: 0x0001DE50 File Offset: 0x0001C050
		[Token(Token = "0x600697E")]
		[Address(RVA = "0x19687A8", Offset = "0x19687A8", VA = "0x7BBC1687A8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1140CB0", Offset = "0x1140CB0")]
		private bool <OnTimeActiveSelected>b__50_0(PlayerSocialTagsData x)
		{
			return default(bool);
		}

		// Token: 0x0600697F RID: 27007 RVA: 0x0001DE68 File Offset: 0x0001C068
		[Token(Token = "0x600697F")]
		[Address(RVA = "0x19687E4", Offset = "0x19687E4", VA = "0x7BBC1687E4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1140CC0", Offset = "0x1140CC0")]
		private bool <OnModeHobbySelected>b__51_0(PlayerSocialTagsData x)
		{
			return default(bool);
		}

		// Token: 0x0400864C RID: 34380
		[Token(Token = "0x400864C")]
		[FieldOffset(Offset = "0x58")]
		private UIAddFriendView m_View;

		// Token: 0x0400864D RID: 34381
		[Token(Token = "0x400864D")]
		[FieldOffset(Offset = "0x60")]
		private bool m_HasSearch;

		// Token: 0x0400864E RID: 34382
		[Token(Token = "0x400864E")]
		[FieldOffset(Offset = "0x64")]
		private int m_scrollWidth;

		// Token: 0x0400864F RID: 34383
		[Token(Token = "0x400864F")]
		[FieldOffset(Offset = "0x68")]
		private UIPopMenuSmallControler m_TimeActivePopMenuController;

		// Token: 0x04008650 RID: 34384
		[Token(Token = "0x4008650")]
		[FieldOffset(Offset = "0x70")]
		private UIPopMenuSmallControler m_ModePreferPopMenuController;

		// Token: 0x04008651 RID: 34385
		[Token(Token = "0x4008651")]
		[FieldOffset(Offset = "0x78")]
		private UIPopMenuSmallControler m_GenderPopMenuController;

		// Token: 0x04008652 RID: 34386
		[Token(Token = "0x4008652")]
		[FieldOffset(Offset = "0x80")]
		private UISelectLanguageController m_UISelectLanguageController;

		// Token: 0x04008653 RID: 34387
		[Token(Token = "0x4008653")]
		[FieldOffset(Offset = "0x88")]
		private List<PlayerSocialTagsData> m_GenderList;

		// Token: 0x04008654 RID: 34388
		[Token(Token = "0x4008654")]
		[FieldOffset(Offset = "0x90")]
		private List<PlayerSocialTagsData> m_TimeActiveList;

		// Token: 0x04008655 RID: 34389
		[Token(Token = "0x4008655")]
		[FieldOffset(Offset = "0x98")]
		private List<PlayerSocialTagsData> m_ModePreferList;

		// Token: 0x04008656 RID: 34390
		[Token(Token = "0x4008656")]
		[FieldOffset(Offset = "0xA0")]
		private List<PopMenuData> m_LanguageDataList;

		// Token: 0x04008657 RID: 34391
		[Token(Token = "0x4008657")]
		private const int TOGGLE_GROUP_ID = 117;

		// Token: 0x04008658 RID: 34392
		[Token(Token = "0x4008658")]
		[FieldOffset(Offset = "0xA8")]
		private ESocial.Language m_SelectedLanguage;

		// Token: 0x04008659 RID: 34393
		[Token(Token = "0x4008659")]
		[FieldOffset(Offset = "0xAC")]
		private ESocial.Gender m_SelectedGender;

		// Token: 0x0400865A RID: 34394
		[Token(Token = "0x400865A")]
		[FieldOffset(Offset = "0xB0")]
		private ESocial.TimeActive m_SelectedTimeActive;

		// Token: 0x0400865B RID: 34395
		[Token(Token = "0x400865B")]
		[FieldOffset(Offset = "0xB4")]
		private ESocial.ModePrefer m_SelectedModePrefer;

		// Token: 0x0400865C RID: 34396
		[Token(Token = "0x400865C")]
		[FieldOffset(Offset = "0xB8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112F82C", Offset = "0x112F82C")]
		private uint <RefreshState>k__BackingField;

		// Token: 0x0200169F RID: 5791
		[Token(Token = "0x200169F")]
		public enum EPlayerSocialType
		{
			// Token: 0x0400865E RID: 34398
			[Token(Token = "0x400865E")]
			Gender = 1,
			// Token: 0x0400865F RID: 34399
			[Token(Token = "0x400865F")]
			TimeActive = 4,
			// Token: 0x04008660 RID: 34400
			[Token(Token = "0x4008660")]
			ModePrefer
		}
	}
}
