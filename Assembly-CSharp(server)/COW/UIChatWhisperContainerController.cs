using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001705 RID: 5893
	[Token(Token = "0x2001705")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F147C", Offset = "0x10F147C")]
	public class UIChatWhisperContainerController : UIChatBaseContainerController, IUIModelDataChangeObserver, IEasyList
	{
		// Token: 0x06006D9A RID: 28058 RVA: 0x0001EE40 File Offset: 0x0001D040
		[Token(Token = "0x6006D9A")]
		[Address(RVA = "0x1BEBBA8", Offset = "0x1BEBBA8", VA = "0x7BBC3EBBA8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006D9B RID: 28059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D9B")]
		[Address(RVA = "0x1BEBBF8", Offset = "0x1BEBBF8", VA = "0x7BBC3EBBF8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006D9C RID: 28060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D9C")]
		[Address(RVA = "0x1BEC22C", Offset = "0x1BEC22C", VA = "0x7BBC3EC22C")]
		private void OnFriendBtnClick()
		{
		}

		// Token: 0x06006D9D RID: 28061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D9D")]
		[Address(RVA = "0x1BEC240", Offset = "0x1BEC240", VA = "0x7BBC3EC240", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06006D9E RID: 28062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D9E")]
		[Address(RVA = "0x1BE3DB8", Offset = "0x1BE3DB8", VA = "0x7BBC3E3DB8")]
		public void GoToWhisperChannel(ulong id, bool forceToFriendTab)
		{
		}

		// Token: 0x06006D9F RID: 28063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D9F")]
		[Address(RVA = "0x1BEC248", Offset = "0x1BEC248", VA = "0x7BBC3EC248", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06006DA0 RID: 28064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DA0")]
		[Address(RVA = "0x1BEC3BC", Offset = "0x1BEC3BC", VA = "0x7BBC3EC3BC", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x06006DA1 RID: 28065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DA1")]
		[Address(RVA = "0x1BEC3F4", Offset = "0x1BEC3F4", VA = "0x7BBC3EC3F4")]
		private void OnSentGiftClick()
		{
		}

		// Token: 0x06006DA2 RID: 28066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DA2")]
		[Address(RVA = "0x1BECB7C", Offset = "0x1BECB7C", VA = "0x7BBC3ECB7C")]
		private void OnProfileClick()
		{
		}

		// Token: 0x06006DA3 RID: 28067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DA3")]
		[Address(RVA = "0x1BECE5C", Offset = "0x1BECE5C", VA = "0x7BBC3ECE5C")]
		private void OnSearchInputGetFocus()
		{
		}

		// Token: 0x06006DA4 RID: 28068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DA4")]
		[Address(RVA = "0x1BECF04", Offset = "0x1BECF04", VA = "0x7BBC3ECF04")]
		private void OnSearchClick()
		{
		}

		// Token: 0x06006DA5 RID: 28069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DA5")]
		[Address(RVA = "0x1BED15C", Offset = "0x1BED15C", VA = "0x7BBC3ED15C")]
		private void ResetInput()
		{
		}

		// Token: 0x06006DA6 RID: 28070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DA6")]
		[Address(RVA = "0x1BED3EC", Offset = "0x1BED3EC", VA = "0x7BBC3ED3EC")]
		private void OnRefreshClick()
		{
		}

		// Token: 0x06006DA7 RID: 28071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DA7")]
		[Address(RVA = "0x1BED680", Offset = "0x1BED680", VA = "0x7BBC3ED680")]
		private void OnRecentTabClick(UIToggleButton button)
		{
		}

		// Token: 0x06006DA8 RID: 28072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DA8")]
		[Address(RVA = "0x1BED7E8", Offset = "0x1BED7E8", VA = "0x7BBC3ED7E8")]
		private void RefreshRecentWhisperNameList()
		{
		}

		// Token: 0x06006DA9 RID: 28073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DA9")]
		[Address(RVA = "0x1BEDF0C", Offset = "0x1BEDF0C", VA = "0x7BBC3EDF0C")]
		private void OnFriendTabClick(UIToggleButton button)
		{
		}

		// Token: 0x06006DAA RID: 28074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DAA")]
		[Address(RVA = "0x1BED230", Offset = "0x1BED230", VA = "0x7BBC3ED230")]
		private void RefreshFriendNameList()
		{
		}

		// Token: 0x06006DAB RID: 28075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DAB")]
		[Address(RVA = "0x1BEE074", Offset = "0x1BEE074", VA = "0x7BBC3EE074", Slot = "28")]
		public override GameObject GetContentNode()
		{
			return null;
		}

		// Token: 0x06006DAC RID: 28076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DAC")]
		[Address(RVA = "0x1BEE0A0", Offset = "0x1BEE0A0", VA = "0x7BBC3EE0A0", Slot = "29")]
		public override GameObject GetEmptyNode()
		{
			return null;
		}

		// Token: 0x06006DAD RID: 28077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DAD")]
		[Address(RVA = "0x1BEE0CC", Offset = "0x1BEE0CC", VA = "0x7BBC3EE0CC", Slot = "30")]
		public override UIScrollView GetMessageList()
		{
			return null;
		}

		// Token: 0x06006DAE RID: 28078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DAE")]
		[Address(RVA = "0x1BEE0F8", Offset = "0x1BEE0F8", VA = "0x7BBC3EE0F8", Slot = "32")]
		public override void RefreshContentNode()
		{
		}

		// Token: 0x06006DAF RID: 28079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DAF")]
		[Address(RVA = "0x1BEE640", Offset = "0x1BEE640", VA = "0x7BBC3EE640", Slot = "31")]
		public override void InitWidget(Transform parent)
		{
		}

		// Token: 0x06006DB0 RID: 28080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DB0")]
		[Address(RVA = "0x1BEEB54", Offset = "0x1BEEB54", VA = "0x7BBC3EEB54", Slot = "33")]
		private void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06006DB1 RID: 28081 RVA: 0x0001EE58 File Offset: 0x0001D058
		[Token(Token = "0x6006DB1")]
		[Address(RVA = "0x1BEEBCC", Offset = "0x1BEEBCC", VA = "0x7BBC3EEBCC", Slot = "34")]
		private uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06006DB2 RID: 28082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DB2")]
		[Address(RVA = "0x1BEEC10", Offset = "0x1BEEC10", VA = "0x7BBC3EEC10", Slot = "35")]
		private UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06006DB3 RID: 28083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DB3")]
		[Address(RVA = "0x1BEECA4", Offset = "0x1BEECA4", VA = "0x7BBC3EECA4", Slot = "36")]
		private void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06006DB4 RID: 28084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DB4")]
		[Address(RVA = "0x1BEECD4", Offset = "0x1BEECD4", VA = "0x7BBC3EECD4")]
		private void OnItemSelect(params object[] param)
		{
		}

		// Token: 0x06006DB5 RID: 28085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DB5")]
		[Address(RVA = "0x1BEF1E8", Offset = "0x1BEF1E8", VA = "0x7BBC3EF1E8")]
		private void OnDeleteClick(params object[] param)
		{
		}

		// Token: 0x06006DB6 RID: 28086 RVA: 0x0001EE70 File Offset: 0x0001D070
		[Token(Token = "0x6006DB6")]
		[Address(RVA = "0x1BED940", Offset = "0x1BED940", VA = "0x7BBC3ED940")]
		private int ConstructCacheList(EWhipserContainerShowTab tab)
		{
			return 0;
		}

		// Token: 0x06006DB7 RID: 28087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DB7")]
		[Address(RVA = "0x1BEF374", Offset = "0x1BEF374", VA = "0x7BBC3EF374")]
		private void OnBaseProfileUpdate(object[] data)
		{
		}

		// Token: 0x06006DB8 RID: 28088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DB8")]
		[Address(RVA = "0x1BEF410", Offset = "0x1BEF410", VA = "0x7BBC3EF410")]
		public UIChatWhisperContainerController()
		{
		}

		// Token: 0x06006DB9 RID: 28089 RVA: 0x0001EE88 File Offset: 0x0001D088
		[Token(Token = "0x6006DB9")]
		[Address(RVA = "0x1BEF488", Offset = "0x1BEF488", VA = "0x7BBC3EF488")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114132C", Offset = "0x114132C")]
		private bool <InitWidget>b__30_0(FriendAccountInfo x)
		{
			return default(bool);
		}

		// Token: 0x06006DBA RID: 28090 RVA: 0x0001EEA0 File Offset: 0x0001D0A0
		[Token(Token = "0x6006DBA")]
		[Address(RVA = "0x1BEF524", Offset = "0x1BEF524", VA = "0x7BBC3EF524")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114133C", Offset = "0x114133C")]
		private int <ConstructCacheList>b__37_0(FriendAccountInfo x, FriendAccountInfo y)
		{
			return 0;
		}

		// Token: 0x040088A6 RID: 34982
		[Token(Token = "0x40088A6")]
		[FieldOffset(Offset = "0x58")]
		private UIChatWhisperContainerView m_View;

		// Token: 0x040088A7 RID: 34983
		[Token(Token = "0x40088A7")]
		[FieldOffset(Offset = "0x60")]
		private UIModelFriends m_FriendsModel;

		// Token: 0x040088A8 RID: 34984
		[Token(Token = "0x40088A8")]
		[FieldOffset(Offset = "0x68")]
		private UIModelChat m_Chat;

		// Token: 0x040088A9 RID: 34985
		[Token(Token = "0x40088A9")]
		[FieldOffset(Offset = "0x70")]
		private List<ChatWhisperNameData> m_CacheList;

		// Token: 0x040088AA RID: 34986
		[Token(Token = "0x40088AA")]
		[FieldOffset(Offset = "0x78")]
		private FriendAccountInfo curWhisperTo;

		// Token: 0x040088AB RID: 34987
		[Token(Token = "0x40088AB")]
		[FieldOffset(Offset = "0x80")]
		private ulong m_LastRefreshTime;

		// Token: 0x040088AC RID: 34988
		[Token(Token = "0x40088AC")]
		[FieldOffset(Offset = "0x88")]
		private bool m_HasSearch;

		// Token: 0x040088AD RID: 34989
		[Token(Token = "0x40088AD")]
		[FieldOffset(Offset = "0x89")]
		private bool m_InputNodeShow;

		// Token: 0x040088AE RID: 34990
		[Token(Token = "0x40088AE")]
		private const float NAMELIST_CLIP_OFFSET_Y = 90f;

		// Token: 0x02001706 RID: 5894
		[Token(Token = "0x2001706")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F14B4", Offset = "0x10F14B4")]
		private sealed class <>c__DisplayClass19_0
		{
			// Token: 0x06006DBB RID: 28091 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006DBB")]
			[Address(RVA = "0x1BED154", Offset = "0x1BED154", VA = "0x7BBC3ED154")]
			public <>c__DisplayClass19_0()
			{
			}

			// Token: 0x06006DBC RID: 28092 RVA: 0x0001EEB8 File Offset: 0x0001D0B8
			[Token(Token = "0x6006DBC")]
			[Address(RVA = "0x1BEF634", Offset = "0x1BEF634", VA = "0x7BBC3EF634")]
			internal bool <OnSearchClick>b__0(ChatWhisperNameData a)
			{
				return default(bool);
			}

			// Token: 0x040088AF RID: 34991
			[Token(Token = "0x40088AF")]
			[FieldOffset(Offset = "0x10")]
			public string name;
		}

		// Token: 0x02001707 RID: 5895
		[Token(Token = "0x2001707")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F14C4", Offset = "0x10F14C4")]
		private sealed class <>c__DisplayClass37_0
		{
			// Token: 0x06006DBD RID: 28093 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006DBD")]
			[Address(RVA = "0x1BEF364", Offset = "0x1BEF364", VA = "0x7BBC3EF364")]
			public <>c__DisplayClass37_0()
			{
			}

			// Token: 0x040088B0 RID: 34992
			[Token(Token = "0x40088B0")]
			[FieldOffset(Offset = "0x10")]
			public List<ChatChannelInfo> list;
		}

		// Token: 0x02001708 RID: 5896
		[Token(Token = "0x2001708")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F14D4", Offset = "0x10F14D4")]
		private sealed class <>c__DisplayClass37_1
		{
			// Token: 0x06006DBE RID: 28094 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006DBE")]
			[Address(RVA = "0x1BEF36C", Offset = "0x1BEF36C", VA = "0x7BBC3EF36C")]
			public <>c__DisplayClass37_1()
			{
			}

			// Token: 0x06006DBF RID: 28095 RVA: 0x0001EED0 File Offset: 0x0001D0D0
			[Token(Token = "0x6006DBF")]
			[Address(RVA = "0x1BEF690", Offset = "0x1BEF690", VA = "0x7BBC3EF690")]
			internal bool <ConstructCacheList>b__1(FriendAccountInfo x)
			{
				return default(bool);
			}

			// Token: 0x040088B1 RID: 34993
			[Token(Token = "0x40088B1")]
			[FieldOffset(Offset = "0x10")]
			public int i;

			// Token: 0x040088B2 RID: 34994
			[Token(Token = "0x40088B2")]
			[FieldOffset(Offset = "0x18")]
			public UIChatWhisperContainerController.<>c__DisplayClass37_0 CS$<>8__locals1;
		}
	}
}
