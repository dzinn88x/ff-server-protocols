using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using tcp;
using UnityEngine;

namespace COW
{
	// Token: 0x020016E4 RID: 5860
	[Token(Token = "0x20016E4")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F0F54", Offset = "0x10F0F54")]
	public class UIBaseChatItemController : UIBaseController
	{
		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x06006C34 RID: 27700 RVA: 0x0001E990 File Offset: 0x0001CB90
		[Token(Token = "0x1700092C")]
		public Bounds bounds
		{
			[Token(Token = "0x6006C34")]
			[Address(RVA = "0x141F668", Offset = "0x141F668", VA = "0x7BBBC1F668")]
			get
			{
				return default(Bounds);
			}
		}

		// Token: 0x06006C35 RID: 27701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C35")]
		[Address(RVA = "0x141F698", Offset = "0x141F698", VA = "0x7BBBC1F698", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006C36 RID: 27702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C36")]
		[Address(RVA = "0x141F9D8", Offset = "0x141F9D8", VA = "0x7BBBC1F9D8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006C37 RID: 27703 RVA: 0x0001E9A8 File Offset: 0x0001CBA8
		[Token(Token = "0x6006C37")]
		[Address(RVA = "0x141F9E0", Offset = "0x141F9E0", VA = "0x7BBBC1F9E0", Slot = "28")]
		protected virtual EChannel.ChannelType GetParentChannelType()
		{
			return EChannel.ChannelType.ChannelType_GROUP;
		}

		// Token: 0x06006C38 RID: 27704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C38")]
		[Address(RVA = "0x141F9E8", Offset = "0x141F9E8", VA = "0x7BBBC1F9E8")]
		protected void OnHeadBtnClick()
		{
		}

		// Token: 0x06006C39 RID: 27705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C39")]
		[Address(RVA = "0x142011C", Offset = "0x142011C", VA = "0x7BBBC2011C")]
		protected void OnQuickAddFriendBtnClick()
		{
		}

		// Token: 0x06006C3A RID: 27706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C3A")]
		[Address(RVA = "0x14203C8", Offset = "0x14203C8", VA = "0x7BBBC203C8", Slot = "29")]
		public virtual void OpenIteractionPanel(InteractionPopUtil.UIInteractionPoptype PopType)
		{
		}

		// Token: 0x06006C3B RID: 27707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C3B")]
		[Address(RVA = "0x14203E8", Offset = "0x14203E8", VA = "0x7BBBC203E8", Slot = "30")]
		public virtual void SetUIData(MessageInfo info, [Optional] Transform parent)
		{
		}

		// Token: 0x06006C3C RID: 27708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C3C")]
		[Address(RVA = "0x14212CC", Offset = "0x14212CC", VA = "0x7BBBC212CC")]
		public void AdjustLayout(float clipWidth)
		{
		}

		// Token: 0x06006C3D RID: 27709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C3D")]
		[Address(RVA = "0x142141C", Offset = "0x142141C", VA = "0x7BBBC2141C", Slot = "31")]
		public virtual void UpdateProfileInfo()
		{
		}

		// Token: 0x06006C3E RID: 27710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C3E")]
		[Address(RVA = "0x14215A0", Offset = "0x14215A0", VA = "0x7BBBC215A0", Slot = "32")]
		protected virtual void OnResendBtnClick()
		{
		}

		// Token: 0x06006C3F RID: 27711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C3F")]
		[Address(RVA = "0x142164C", Offset = "0x142164C", VA = "0x7BBBC2164C", Slot = "33")]
		protected virtual void OnClickJoin()
		{
		}

		// Token: 0x06006C40 RID: 27712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C40")]
		[Address(RVA = "0x14216F8", Offset = "0x14216F8", VA = "0x7BBBC216F8")]
		protected void OnContentClick()
		{
		}

		// Token: 0x06006C41 RID: 27713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C41")]
		[Address(RVA = "0x1421960", Offset = "0x1421960", VA = "0x7BBBC21960")]
		protected static void CopyToClipBoard(object content)
		{
		}

		// Token: 0x06006C42 RID: 27714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C42")]
		[Address(RVA = "0x1421B7C", Offset = "0x1421B7C", VA = "0x7BBBC21B7C")]
		public UIBaseChatItemController()
		{
		}

		// Token: 0x06006C43 RID: 27715 RVA: 0x0001E9C0 File Offset: 0x0001CBC0
		[Token(Token = "0x6006C43")]
		[Address(RVA = "0x1421B84", Offset = "0x1421B84", VA = "0x7BBBC21B84")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11412AC", Offset = "0x11412AC")]
		private bool <OnHeadBtnClick>b__26_0(ClanMember temp)
		{
			return default(bool);
		}

		// Token: 0x06006C44 RID: 27716 RVA: 0x0001E9D8 File Offset: 0x0001CBD8
		[Token(Token = "0x6006C44")]
		[Address(RVA = "0x1421BE8", Offset = "0x1421BE8", VA = "0x7BBBC21BE8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11412BC", Offset = "0x11412BC")]
		private bool <OnHeadBtnClick>b__26_1(ClanMember temp)
		{
			return default(bool);
		}

		// Token: 0x040087E0 RID: 34784
		[Token(Token = "0x40087E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected BaseChatMessageView LeftView;

		// Token: 0x040087E1 RID: 34785
		[Token(Token = "0x40087E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected UIButton headbtnleft;

		// Token: 0x040087E2 RID: 34786
		[Token(Token = "0x40087E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected UIButton LeftContentBtn;

		// Token: 0x040087E3 RID: 34787
		[Token(Token = "0x40087E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected BaseChatMessageView RightView;

		// Token: 0x040087E4 RID: 34788
		[Token(Token = "0x40087E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected UIButton headbtn;

		// Token: 0x040087E5 RID: 34789
		[Token(Token = "0x40087E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		protected UIButton RightContentBtn;

		// Token: 0x040087E6 RID: 34790
		[Token(Token = "0x40087E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		protected UIButton QuickAddFriendBtn;

		// Token: 0x040087E7 RID: 34791
		[Token(Token = "0x40087E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		protected UILabel QuickAddFriendLabel;

		// Token: 0x040087E8 RID: 34792
		[Token(Token = "0x40087E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected GameObject ChatTips;

		// Token: 0x040087E9 RID: 34793
		[Token(Token = "0x40087E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		protected GameObject PrivateWarning;

		// Token: 0x040087EA RID: 34794
		[Token(Token = "0x40087EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		protected GameObject AddFriendTip;

		// Token: 0x040087EB RID: 34795
		[Token(Token = "0x40087EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected GameObject AddFriendBtnContainer;

		// Token: 0x040087EC RID: 34796
		[Token(Token = "0x40087EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected UISprite AddFriendBtnSprite;

		// Token: 0x040087ED RID: 34797
		[Token(Token = "0x40087ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		protected UISprite AddFriendBtnIcon;

		// Token: 0x040087EE RID: 34798
		[Token(Token = "0x40087EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		protected UISprite AddFriendBtnLight;

		// Token: 0x040087EF RID: 34799
		[Token(Token = "0x40087EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		protected MessageInfo m_Data;

		// Token: 0x040087F0 RID: 34800
		[Token(Token = "0x40087F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private float defaultLeftViewOffset;

		// Token: 0x040087F1 RID: 34801
		[Token(Token = "0x40087F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private float defaultRightViewOffset;

		// Token: 0x040087F2 RID: 34802
		[Token(Token = "0x40087F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private float defaultItemWidth;

		// Token: 0x040087F3 RID: 34803
		[Token(Token = "0x40087F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private UIBigEventChatMsgItemController m_LeftBigEventMsgItemCtrl;

		// Token: 0x040087F4 RID: 34804
		[Token(Token = "0x40087F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private UIBigEventChatMsgItemController m_RightBigEventMsgItemCtrl;
	}
}
