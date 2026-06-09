using System;
using GCommon;
using Il2CppDummyDll;
using tcp;
using UnityEngine;

namespace COW
{
	// Token: 0x020019F2 RID: 6642
	[Token(Token = "0x20019F2")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F74AC", Offset = "0x10F74AC")]
	public class UILobbyChatController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x06008960 RID: 35168 RVA: 0x00024E88 File Offset: 0x00023088
		[Token(Token = "0x6008960")]
		[Address(RVA = "0x152A27C", Offset = "0x152A27C", VA = "0x7BBBD2A27C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008961 RID: 35169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008961")]
		[Address(RVA = "0x152A2CC", Offset = "0x152A2CC", VA = "0x7BBBD2A2CC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008962 RID: 35170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008962")]
		[Address(RVA = "0x152A8E4", Offset = "0x152A8E4", VA = "0x7BBBD2A8E4")]
		private void OnRecruitBtnClick()
		{
		}

		// Token: 0x06008963 RID: 35171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008963")]
		[Address(RVA = "0x152ADB8", Offset = "0x152ADB8", VA = "0x7BBBD2ADB8")]
		private void OnFastSendGiftBtnClick()
		{
		}

		// Token: 0x06008964 RID: 35172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008964")]
		[Address(RVA = "0x152B27C", Offset = "0x152B27C", VA = "0x7BBBD2B27C")]
		private void OnChatMessageBtnClick()
		{
		}

		// Token: 0x06008965 RID: 35173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008965")]
		[Address(RVA = "0x152B450", Offset = "0x152B450", VA = "0x7BBBD2B450", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008966 RID: 35174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008966")]
		[Address(RVA = "0x152B674", Offset = "0x152B674", VA = "0x7BBBD2B674")]
		private void OnChatBtnClick()
		{
		}

		// Token: 0x06008967 RID: 35175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008967")]
		[Address(RVA = "0x152B908", Offset = "0x152B908", VA = "0x7BBBD2B908", Slot = "28")]
		private void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06008968 RID: 35176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008968")]
		[Address(RVA = "0x152BA18", Offset = "0x152BA18", VA = "0x7BBBD2BA18")]
		private void RefreshLatestMessage()
		{
		}

		// Token: 0x06008969 RID: 35177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008969")]
		[Address(RVA = "0x152C08C", Offset = "0x152C08C", VA = "0x7BBBD2C08C")]
		private void OnScrollFinish()
		{
		}

		// Token: 0x0600896A RID: 35178 RVA: 0x00024EA0 File Offset: 0x000230A0
		[Token(Token = "0x600896A")]
		[Address(RVA = "0x152C138", Offset = "0x152C138", VA = "0x7BBBD2C138", Slot = "29")]
		private uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600896B RID: 35179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600896B")]
		[Address(RVA = "0x152A720", Offset = "0x152A720", VA = "0x7BBBD2A720")]
		private void RefreshBtnState(params object[] data)
		{
		}

		// Token: 0x0600896C RID: 35180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600896C")]
		[Address(RVA = "0x152C17C", Offset = "0x152C17C", VA = "0x7BBBD2C17C")]
		public UILobbyChatController()
		{
		}

		// Token: 0x0400977F RID: 38783
		[Token(Token = "0x400977F")]
		[FieldOffset(Offset = "0x58")]
		private UILobbyChatView m_View;

		// Token: 0x04009780 RID: 38784
		[Token(Token = "0x4009780")]
		[FieldOffset(Offset = "0x60")]
		private UIModelChat m_ChatModel;

		// Token: 0x04009781 RID: 38785
		[Token(Token = "0x4009781")]
		[FieldOffset(Offset = "0x68")]
		private UIModelGroup m_GroupModel;

		// Token: 0x04009782 RID: 38786
		[Token(Token = "0x4009782")]
		[FieldOffset(Offset = "0x70")]
		private uint m_MessageDispearCallID;

		// Token: 0x04009783 RID: 38787
		[Token(Token = "0x4009783")]
		[FieldOffset(Offset = "0x74")]
		private int m_MessageLabelOrigWidth;

		// Token: 0x04009784 RID: 38788
		[Token(Token = "0x4009784")]
		[FieldOffset(Offset = "0x0")]
		public static Vector3 LOBBY_CHAT_POSITION;

		// Token: 0x04009785 RID: 38789
		[Token(Token = "0x4009785")]
		[FieldOffset(Offset = "0xC")]
		public static Vector3 LOBBY_CHAT_OFFSET_POSITION;

		// Token: 0x04009786 RID: 38790
		[Token(Token = "0x4009786")]
		[FieldOffset(Offset = "0x18")]
		public static Vector3 CUSTOMROOM_CHAT_POSITION;

		// Token: 0x04009787 RID: 38791
		[Token(Token = "0x4009787")]
		[FieldOffset(Offset = "0x24")]
		public static Vector3 CHAT_POSITION_WHEN_UPPERRIGHT;

		// Token: 0x04009788 RID: 38792
		[Token(Token = "0x4009788")]
		private const string LOBBY_MESSAGE_PREFIX_CLAN = "TXT_LOBBY_MESSAGE_PREFIX_CLAN";

		// Token: 0x04009789 RID: 38793
		[Token(Token = "0x4009789")]
		private const string LOBBY_MESSAGE_PREFIX_GROUP = "TXT_LOBBY_MESSAGE_PREFIX_GROUP";

		// Token: 0x0400978A RID: 38794
		[Token(Token = "0x400978A")]
		private const string LOBBY_MESSAGE_PREFIX_WHISPER = "TXT_OB10_ZC_CHANNEL_WHISPER";

		// Token: 0x0400978B RID: 38795
		[Token(Token = "0x400978B")]
		private const string LOBBY_MESSAGE_PREFIX_ROOM = "T_12_Z_MESSAGE_PREFIX_ROOM";

		// Token: 0x0400978C RID: 38796
		[Token(Token = "0x400978C")]
		private const string LOBBY_MESSAGE_PREFIX_WORLD = "T_20_P_CHANNEL_W_E";

		// Token: 0x0400978D RID: 38797
		[Token(Token = "0x400978D")]
		private const string LOBBY_EMOJI_MESSAGE = "T_12_A_CHAT_LOBBY_EMOJI";

		// Token: 0x0400978E RID: 38798
		[Token(Token = "0x400978E")]
		private const string LOBBY_FAST_GROUP = "T_20_P_CHANNEL_ENTRANCE_I";

		// Token: 0x0400978F RID: 38799
		[Token(Token = "0x400978F")]
		private const string LOBBY_FAST_CLAN = "T_20_P_CHANNEL_ENTRANCE_R";

		// Token: 0x04009790 RID: 38800
		[Token(Token = "0x4009790")]
		private const string LATEST_MESSAGE_FORMAT = "{0} {1}: {2}";

		// Token: 0x04009791 RID: 38801
		[Token(Token = "0x4009791")]
		private const string STICKY_MESSAGE_COLOR_FORMAT = "[ffd451]{0}[-]";

		// Token: 0x020019F3 RID: 6643
		[Token(Token = "0x20019F3")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F74E4", Offset = "0x10F74E4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600896F RID: 35183 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600896F")]
			[Address(RVA = "0x152C330", Offset = "0x152C330", VA = "0x7BBBD2C330")]
			public <>c()
			{
			}

			// Token: 0x06008970 RID: 35184 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6008970")]
			[Address(RVA = "0x152C338", Offset = "0x152C338", VA = "0x7BBBD2C338")]
			internal FriendInfo <OnFastSendGiftBtnClick>b__22_0(GroupMemberInfo teammate)
			{
				return null;
			}

			// Token: 0x04009792 RID: 38802
			[Token(Token = "0x4009792")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UILobbyChatController.<>c <>9;

			// Token: 0x04009793 RID: 38803
			[Token(Token = "0x4009793")]
			[FieldOffset(Offset = "0x8")]
			public static Converter<GroupMemberInfo, FriendInfo> <>9__22_0;
		}
	}
}
