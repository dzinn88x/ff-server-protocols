using System;
using System.Collections.Generic;
using System.Text;
using GCommon;
using Il2CppDummyDll;
using tcp;
using UnityEngine;

namespace COW
{
	// Token: 0x020016F9 RID: 5881
	[Token(Token = "0x20016F9")]
	public class UIChatController : UIBaseChatController<UIChatMessageItemController>
	{
		// Token: 0x06006D41 RID: 27969 RVA: 0x0001ECC0 File Offset: 0x0001CEC0
		[Token(Token = "0x6006D41")]
		[Address(RVA = "0x1BE1B10", Offset = "0x1BE1B10", VA = "0x7BBC3E1B10")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006D42 RID: 27970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D42")]
		[Address(RVA = "0x1BE1B60", Offset = "0x1BE1B60", VA = "0x7BBC3E1B60", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006D43 RID: 27971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D43")]
		[Address(RVA = "0x1BE1FF8", Offset = "0x1BE1FF8", VA = "0x7BBC3E1FF8", Slot = "33")]
		protected override void AfterInit()
		{
		}

		// Token: 0x06006D44 RID: 27972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D44")]
		[Address(RVA = "0x1BE2C10", Offset = "0x1BE2C10", VA = "0x7BBC3E2C10", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x06006D45 RID: 27973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D45")]
		[Address(RVA = "0x1BE2C90", Offset = "0x1BE2C90", VA = "0x7BBC3E2C90", Slot = "32")]
		protected override ChatChannelInfo GetCurShowChannel()
		{
			return null;
		}

		// Token: 0x06006D46 RID: 27974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D46")]
		[Address(RVA = "0x1BE2D48", Offset = "0x1BE2D48", VA = "0x7BBC3E2D48", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006D47 RID: 27975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D47")]
		[Address(RVA = "0x1BE2F74", Offset = "0x1BE2F74", VA = "0x7BBC3E2F74", Slot = "40")]
		protected override void OnChatDataChanged(uint propID, params object[] param)
		{
		}

		// Token: 0x06006D48 RID: 27976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D48")]
		[Address(RVA = "0x1BE3050", Offset = "0x1BE3050", VA = "0x7BBC3E3050")]
		private void RefreshChannelList()
		{
		}

		// Token: 0x06006D49 RID: 27977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D49")]
		[Address(RVA = "0x1BE36CC", Offset = "0x1BE36CC", VA = "0x7BBC3E36CC", Slot = "41")]
		protected override void RefreshContentNode()
		{
		}

		// Token: 0x06006D4A RID: 27978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D4A")]
		[Address(RVA = "0x1BE3A3C", Offset = "0x1BE3A3C", VA = "0x7BBC3E3A3C")]
		private UIChatBaseContainerController GetOrCreateContainerCtrl(EChannel.ChannelType m_ChannelType)
		{
			return null;
		}

		// Token: 0x06006D4B RID: 27979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D4B")]
		[Address(RVA = "0x1BE32F0", Offset = "0x1BE32F0", VA = "0x7BBC3E32F0")]
		public void GotoChannel(EChannel.ChannelType type, ulong roomid = 0UL, bool forceToFriendTab = true)
		{
		}

		// Token: 0x06006D4C RID: 27980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D4C")]
		[Address(RVA = "0x1BE405C", Offset = "0x1BE405C", VA = "0x7BBC3E405C")]
		private void OnSwitchChannel(object[] data)
		{
		}

		// Token: 0x06006D4D RID: 27981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D4D")]
		[Address(RVA = "0x1BE3D30", Offset = "0x1BE3D30", VA = "0x7BBC3E3D30")]
		private UIChatBaseContainerController GetContainerCtrl(EChannel.ChannelType m_ChannelType)
		{
			return null;
		}

		// Token: 0x06006D4E RID: 27982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D4E")]
		[Address(RVA = "0x1BE4564", Offset = "0x1BE4564", VA = "0x7BBC3E4564")]
		private void OnBaseProfileUpdate(object[] data)
		{
		}

		// Token: 0x06006D4F RID: 27983 RVA: 0x0001ECD8 File Offset: 0x0001CED8
		[Token(Token = "0x6006D4F")]
		[Address(RVA = "0x1BE45B4", Offset = "0x1BE45B4", VA = "0x7BBC3E45B4", Slot = "43")]
		protected override uint GetChatInterestedPropID()
		{
			return 0U;
		}

		// Token: 0x06006D50 RID: 27984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D50")]
		[Address(RVA = "0x1BE460C", Offset = "0x1BE460C", VA = "0x7BBC3E460C", Slot = "39")]
		public override void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06006D51 RID: 27985 RVA: 0x0001ECF0 File Offset: 0x0001CEF0
		[Token(Token = "0x6006D51")]
		[Address(RVA = "0x1BE46D4", Offset = "0x1BE46D4", VA = "0x7BBC3E46D4", Slot = "42")]
		public override uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06006D52 RID: 27986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D52")]
		[Address(RVA = "0x1BE476C", Offset = "0x1BE476C", VA = "0x7BBC3E476C", Slot = "37")]
		protected override void AfterSendSuccess()
		{
		}

		// Token: 0x06006D53 RID: 27987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D53")]
		[Address(RVA = "0x1BE4858", Offset = "0x1BE4858", VA = "0x7BBC3E4858")]
		private void OnSpeakerSend(object[] data)
		{
		}

		// Token: 0x06006D54 RID: 27988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D54")]
		[Address(RVA = "0x1BE243C", Offset = "0x1BE243C", VA = "0x7BBC3E243C")]
		private void RefreshSpeakerNum()
		{
		}

		// Token: 0x06006D55 RID: 27989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D55")]
		[Address(RVA = "0x1BE4868", Offset = "0x1BE4868", VA = "0x7BBC3E4868")]
		private void OnSpeakerClick()
		{
		}

		// Token: 0x06006D56 RID: 27990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D56")]
		[Address(RVA = "0x1BE42C8", Offset = "0x1BE42C8", VA = "0x7BBC3E42C8")]
		private void RefreshDefaultInputValue()
		{
		}

		// Token: 0x06006D57 RID: 27991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D57")]
		[Address(RVA = "0x1BE26D0", Offset = "0x1BE26D0", VA = "0x7BBC3E26D0")]
		private void ResetDefaultInputValue()
		{
		}

		// Token: 0x06006D58 RID: 27992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D58")]
		[Address(RVA = "0x1BE4CB4", Offset = "0x1BE4CB4", VA = "0x7BBC3E4CB4")]
		public UIChatController()
		{
		}

		// Token: 0x06006D59 RID: 27993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D59")]
		[Address(RVA = "0x1BE4D54", Offset = "0x1BE4D54", VA = "0x7BBC3E4D54")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114130C", Offset = "0x114130C")]
		private void <AfterSendSuccess>b__24_0()
		{
		}

		// Token: 0x04008881 RID: 34945
		[Token(Token = "0x4008881")]
		[FieldOffset(Offset = "0x1A8")]
		private UIChatView m_View;

		// Token: 0x04008882 RID: 34946
		[Token(Token = "0x4008882")]
		[FieldOffset(Offset = "0x1B0")]
		private List<ChatChannelInfo> m_ShowChannelList;

		// Token: 0x04008883 RID: 34947
		[Token(Token = "0x4008883")]
		[FieldOffset(Offset = "0x1B8")]
		private uint m_WorldCDCallID;

		// Token: 0x04008884 RID: 34948
		[Token(Token = "0x4008884")]
		[FieldOffset(Offset = "0x1C0")]
		private StringBuilder m_WorldCDText;

		// Token: 0x04008885 RID: 34949
		[Token(Token = "0x4008885")]
		[FieldOffset(Offset = "0x1C8")]
		private Dictionary<int, UIChatBaseContainerController> m_ChannelType2Container;

		// Token: 0x04008886 RID: 34950
		[Token(Token = "0x4008886")]
		[FieldOffset(Offset = "0x1D0")]
		private Vector3 m_NewMessageNodeOrgPos;

		// Token: 0x04008887 RID: 34951
		[Token(Token = "0x4008887")]
		private const int NEW_MESSAGE_NODE_OFFSET_Y = 90;

		// Token: 0x020016FA RID: 5882
		[Token(Token = "0x20016FA")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F131C", Offset = "0x10F131C")]
		private sealed class <>c__DisplayClass17_0
		{
			// Token: 0x06006D5A RID: 27994 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006D5A")]
			[Address(RVA = "0x1BE3DB0", Offset = "0x1BE3DB0", VA = "0x7BBC3E3DB0")]
			public <>c__DisplayClass17_0()
			{
			}

			// Token: 0x06006D5B RID: 27995 RVA: 0x0001ED08 File Offset: 0x0001CF08
			[Token(Token = "0x6006D5B")]
			[Address(RVA = "0x1BE4D58", Offset = "0x1BE4D58", VA = "0x7BBC3E4D58")]
			internal bool <GotoChannel>b__0(ChatChannelInfo x)
			{
				return default(bool);
			}

			// Token: 0x04008888 RID: 34952
			[Token(Token = "0x4008888")]
			[FieldOffset(Offset = "0x10")]
			public EChannel.ChannelType type;
		}
	}
}
