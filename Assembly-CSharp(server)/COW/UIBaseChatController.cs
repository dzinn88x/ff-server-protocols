using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020016E2 RID: 5858
	[Token(Token = "0x20016E2")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F0F0C", Offset = "0x10F0F0C")]
	public class UIBaseChatController<T> : UIBaseController, IUIModelDataChangeObserver, IEasyList where T : UIBaseChatItemController
	{
		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x06006C07 RID: 27655 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006C08 RID: 27656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700092B")]
		public ChatChannelInfo curShowChannel
		{
			[Token(Token = "0x6006C07")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114128C", Offset = "0x114128C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006C08")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114129C", Offset = "0x114129C")]
			protected set
			{
			}
		}

		// Token: 0x06006C09 RID: 27657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C09")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006C0A RID: 27658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C0A")]
		protected virtual ChatChannelInfo GetCurShowChannel()
		{
			return null;
		}

		// Token: 0x06006C0B RID: 27659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C0B")]
		protected virtual void AfterInit()
		{
		}

		// Token: 0x06006C0C RID: 27660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C0C")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06006C0D RID: 27661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C0D")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x06006C0E RID: 27662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C0E")]
		private void LateUpdate()
		{
		}

		// Token: 0x06006C0F RID: 27663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C0F")]
		private void OnStickerPurchaseBtnClick()
		{
		}

		// Token: 0x06006C10 RID: 27664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C10")]
		private void PurchaseSticker()
		{
		}

		// Token: 0x06006C11 RID: 27665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C11")]
		private void OnCloseStickerBtnClick()
		{
		}

		// Token: 0x06006C12 RID: 27666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C12")]
		private void OnOpenStickerBtnClick()
		{
		}

		// Token: 0x06006C13 RID: 27667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C13")]
		protected virtual void OnStickerSpriteClick(params object[] data)
		{
		}

		// Token: 0x06006C14 RID: 27668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C14")]
		protected virtual void OnStickerTabClick(params object[] data)
		{
		}

		// Token: 0x06006C15 RID: 27669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C15")]
		protected virtual void OnEnterBtnClick()
		{
		}

		// Token: 0x06006C16 RID: 27670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C16")]
		private void OnMutedHintBtnClick()
		{
		}

		// Token: 0x06006C17 RID: 27671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C17")]
		protected virtual void AfterSendSuccess()
		{
		}

		// Token: 0x06006C18 RID: 27672 RVA: 0x0001E900 File Offset: 0x0001CB00
		[Token(Token = "0x6006C18")]
		protected virtual char OnInputValidate(string text, int charIndex, char addedChar)
		{
			return '\0';
		}

		// Token: 0x06006C19 RID: 27673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C19")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006C1A RID: 27674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C1A")]
		public virtual void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06006C1B RID: 27675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C1B")]
		protected virtual void OnChatDataChanged(uint propID, params object[] param)
		{
		}

		// Token: 0x06006C1C RID: 27676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C1C")]
		protected virtual void RefreshContentNode()
		{
		}

		// Token: 0x06006C1D RID: 27677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C1D")]
		protected void RebuildMessageList()
		{
		}

		// Token: 0x06006C1E RID: 27678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C1E")]
		protected void UpdateNewMessageList()
		{
		}

		// Token: 0x06006C1F RID: 27679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C1F")]
		protected void RefreshMessageList()
		{
		}

		// Token: 0x06006C20 RID: 27680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C20")]
		private void CheckAndHideNewMessageTip()
		{
		}

		// Token: 0x06006C21 RID: 27681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C21")]
		protected void OnStopMoving()
		{
		}

		// Token: 0x06006C22 RID: 27682 RVA: 0x0001E918 File Offset: 0x0001CB18
		[Token(Token = "0x6006C22")]
		public virtual uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06006C23 RID: 27683 RVA: 0x0001E930 File Offset: 0x0001CB30
		[Token(Token = "0x6006C23")]
		protected virtual uint GetChatInterestedPropID()
		{
			return 0U;
		}

		// Token: 0x06006C24 RID: 27684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C24")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06006C25 RID: 27685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C25")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06006C26 RID: 27686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C26")]
		private void OnCloseBtnClick()
		{
		}

		// Token: 0x06006C27 RID: 27687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C27")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06006C28 RID: 27688 RVA: 0x0001E948 File Offset: 0x0001CB48
		[Token(Token = "0x6006C28")]
		private bool IsAtBottom()
		{
			return default(bool);
		}

		// Token: 0x06006C29 RID: 27689 RVA: 0x0001E960 File Offset: 0x0001CB60
		[Token(Token = "0x6006C29")]
		private bool IsAtTop()
		{
			return default(bool);
		}

		// Token: 0x06006C2A RID: 27690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C2A")]
		private void ScrollToBottom()
		{
		}

		// Token: 0x06006C2B RID: 27691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C2B")]
		private void RefreshAllContent()
		{
		}

		// Token: 0x06006C2C RID: 27692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C2C")]
		private void WrapInitializeItem(int fromIndex, int toIndex)
		{
		}

		// Token: 0x06006C2D RID: 27693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C2D")]
		protected virtual T GetAnInstance()
		{
			return null;
		}

		// Token: 0x06006C2E RID: 27694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C2E")]
		protected void GetMessageList()
		{
		}

		// Token: 0x06006C2F RID: 27695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C2F")]
		protected void SetNewMessageBtnVisible(bool v)
		{
		}

		// Token: 0x06006C30 RID: 27696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C30")]
		public UIBaseChatController()
		{
		}

		// Token: 0x040087B0 RID: 34736
		[Token(Token = "0x40087B0")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112F84C", Offset = "0x112F84C")]
		private ChatChannelInfo <curShowChannel>k__BackingField;

		// Token: 0x040087B1 RID: 34737
		[Token(Token = "0x40087B1")]
		[FieldOffset(Offset = "0x0")]
		protected UIModelChat m_Model;

		// Token: 0x040087B2 RID: 34738
		[Token(Token = "0x40087B2")]
		[FieldOffset(Offset = "0x0")]
		protected List<T> m_ControllerList;

		// Token: 0x040087B3 RID: 34739
		[Token(Token = "0x40087B3")]
		[FieldOffset(Offset = "0x0")]
		protected Queue<T> m_ControllerPool;

		// Token: 0x040087B4 RID: 34740
		[Token(Token = "0x40087B4")]
		[FieldOffset(Offset = "0x0")]
		protected List<MessageInfo> m_MessageList;

		// Token: 0x040087B5 RID: 34741
		[Token(Token = "0x40087B5")]
		[FieldOffset(Offset = "0x0")]
		protected List<StickerSpriteView> m_StickerSpriteViewList;

		// Token: 0x040087B6 RID: 34742
		[Token(Token = "0x40087B6")]
		[FieldOffset(Offset = "0x0")]
		protected List<StickerTabView> m_StickerTabViewList;

		// Token: 0x040087B7 RID: 34743
		[Token(Token = "0x40087B7")]
		[FieldOffset(Offset = "0x0")]
		protected UICountDownController m_MutedCDCtrl;

		// Token: 0x040087B8 RID: 34744
		[Token(Token = "0x40087B8")]
		[FieldOffset(Offset = "0x0")]
		protected float lastItemPosY;

		// Token: 0x040087B9 RID: 34745
		[Token(Token = "0x40087B9")]
		[FieldOffset(Offset = "0x0")]
		protected float firstItemPosY;

		// Token: 0x040087BA RID: 34746
		[Token(Token = "0x40087BA")]
		[FieldOffset(Offset = "0x0")]
		protected int lastItemIndex;

		// Token: 0x040087BB RID: 34747
		[Token(Token = "0x40087BB")]
		[FieldOffset(Offset = "0x0")]
		protected int firstItemIndex;

		// Token: 0x040087BC RID: 34748
		[Token(Token = "0x40087BC")]
		protected const int ITEM_COUNT_PERPAGE = 10;

		// Token: 0x040087BD RID: 34749
		[Token(Token = "0x40087BD")]
		[FieldOffset(Offset = "0x0")]
		protected bool m_HasInitSticker;

		// Token: 0x040087BE RID: 34750
		[Token(Token = "0x40087BE")]
		[FieldOffset(Offset = "0x0")]
		protected uint currentSelectSticker;

		// Token: 0x040087BF RID: 34751
		[Token(Token = "0x40087BF")]
		[FieldOffset(Offset = "0x0")]
		protected GameObject NewMessage;

		// Token: 0x040087C0 RID: 34752
		[Token(Token = "0x40087C0")]
		[FieldOffset(Offset = "0x0")]
		protected GameObject ContentNode;

		// Token: 0x040087C1 RID: 34753
		[Token(Token = "0x40087C1")]
		[FieldOffset(Offset = "0x0")]
		protected UIInput InputContainer;

		// Token: 0x040087C2 RID: 34754
		[Token(Token = "0x40087C2")]
		[FieldOffset(Offset = "0x0")]
		protected UIScrollView MessageList;

		// Token: 0x040087C3 RID: 34755
		[Token(Token = "0x40087C3")]
		[FieldOffset(Offset = "0x0")]
		protected UITable MessageListTable;

		// Token: 0x040087C4 RID: 34756
		[Token(Token = "0x40087C4")]
		[FieldOffset(Offset = "0x0")]
		protected GameObject EmptyNode;

		// Token: 0x040087C5 RID: 34757
		[Token(Token = "0x40087C5")]
		[FieldOffset(Offset = "0x0")]
		protected UIButton EnterBtn;

		// Token: 0x040087C6 RID: 34758
		[Token(Token = "0x40087C6")]
		[FieldOffset(Offset = "0x0")]
		protected UIButton OpenStickerBtn;

		// Token: 0x040087C7 RID: 34759
		[Token(Token = "0x40087C7")]
		[FieldOffset(Offset = "0x0")]
		protected UIButton NewMessageBtn;

		// Token: 0x040087C8 RID: 34760
		[Token(Token = "0x40087C8")]
		[FieldOffset(Offset = "0x0")]
		protected UILabel NewMessageLabel;

		// Token: 0x040087C9 RID: 34761
		[Token(Token = "0x40087C9")]
		[FieldOffset(Offset = "0x0")]
		protected GameObject IngameHint;

		// Token: 0x040087CA RID: 34762
		[Token(Token = "0x40087CA")]
		[FieldOffset(Offset = "0x0")]
		protected UILabel WhisperStatusHint;

		// Token: 0x040087CB RID: 34763
		[Token(Token = "0x40087CB")]
		[FieldOffset(Offset = "0x0")]
		protected GameObject StickerNode;

		// Token: 0x040087CC RID: 34764
		[Token(Token = "0x40087CC")]
		[FieldOffset(Offset = "0x0")]
		protected UIButton CloseStickerBtn;

		// Token: 0x040087CD RID: 34765
		[Token(Token = "0x40087CD")]
		[FieldOffset(Offset = "0x0")]
		protected UIToggleButtonGroup StickerToggleBtnGroup;

		// Token: 0x040087CE RID: 34766
		[Token(Token = "0x40087CE")]
		[FieldOffset(Offset = "0x0")]
		protected UIGrid StickerTabGrid;

		// Token: 0x040087CF RID: 34767
		[Token(Token = "0x40087CF")]
		[FieldOffset(Offset = "0x0")]
		protected StickerTabView StickerTabItemInstance;

		// Token: 0x040087D0 RID: 34768
		[Token(Token = "0x40087D0")]
		[FieldOffset(Offset = "0x0")]
		protected UIScrollView StickerSpriteList;

		// Token: 0x040087D1 RID: 34769
		[Token(Token = "0x40087D1")]
		[FieldOffset(Offset = "0x0")]
		protected UITable StickerSpriteTable;

		// Token: 0x040087D2 RID: 34770
		[Token(Token = "0x40087D2")]
		[FieldOffset(Offset = "0x0")]
		protected StickerSpriteView StickerSpriteInstance;

		// Token: 0x040087D3 RID: 34771
		[Token(Token = "0x40087D3")]
		[FieldOffset(Offset = "0x0")]
		protected UIButton PurchaseBtn;

		// Token: 0x040087D4 RID: 34772
		[Token(Token = "0x40087D4")]
		[FieldOffset(Offset = "0x0")]
		protected GameObject PurchaseGO;

		// Token: 0x040087D5 RID: 34773
		[Token(Token = "0x40087D5")]
		[FieldOffset(Offset = "0x0")]
		protected GameObject DiamondGO;

		// Token: 0x040087D6 RID: 34774
		[Token(Token = "0x40087D6")]
		[FieldOffset(Offset = "0x0")]
		protected UILabel StickerPriceDiamond;

		// Token: 0x040087D7 RID: 34775
		[Token(Token = "0x40087D7")]
		[FieldOffset(Offset = "0x0")]
		protected GameObject CoinGO;

		// Token: 0x040087D8 RID: 34776
		[Token(Token = "0x40087D8")]
		[FieldOffset(Offset = "0x0")]
		protected UILabel StickerPriceCoin;

		// Token: 0x040087D9 RID: 34777
		[Token(Token = "0x40087D9")]
		[FieldOffset(Offset = "0x0")]
		protected GameObject OwnedObject;

		// Token: 0x040087DA RID: 34778
		[Token(Token = "0x40087DA")]
		[FieldOffset(Offset = "0x0")]
		protected GameObject MutedNode;

		// Token: 0x040087DB RID: 34779
		[Token(Token = "0x40087DB")]
		[FieldOffset(Offset = "0x0")]
		protected GameObject SendMessageNode;

		// Token: 0x040087DC RID: 34780
		[Token(Token = "0x40087DC")]
		[FieldOffset(Offset = "0x0")]
		protected Transform MutedCountDown;

		// Token: 0x040087DD RID: 34781
		[Token(Token = "0x40087DD")]
		[FieldOffset(Offset = "0x0")]
		protected UIButton MutedHintBtn;

		// Token: 0x020016E3 RID: 5859
		[Token(Token = "0x20016E3")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F0F44", Offset = "0x10F0F44")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06006C32 RID: 27698 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C32")]
			public <>c()
			{
			}

			// Token: 0x06006C33 RID: 27699 RVA: 0x0001E978 File Offset: 0x0001CB78
			[Token(Token = "0x6006C33")]
			internal int <OnOpenStickerBtnClick>b__58_0(ChatStickerPrice a, ChatStickerPrice b)
			{
				return 0;
			}

			// Token: 0x040087DE RID: 34782
			[Token(Token = "0x40087DE")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIBaseChatController<T>.<>c <>9;

			// Token: 0x040087DF RID: 34783
			[Token(Token = "0x40087DF")]
			[FieldOffset(Offset = "0x0")]
			public static Comparison<ChatStickerPrice> <>9__58_0;
		}
	}
}
