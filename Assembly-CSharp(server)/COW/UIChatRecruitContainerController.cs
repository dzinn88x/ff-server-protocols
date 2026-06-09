using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020016FF RID: 5887
	[Token(Token = "0x20016FF")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F139C", Offset = "0x10F139C")]
	public class UIChatRecruitContainerController : UIChatBaseContainerController, IUIModelDataChangeObserver, IEasyList
	{
		// Token: 0x06006D72 RID: 28018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D72")]
		[Address(RVA = "0x1BE653C", Offset = "0x1BE653C", VA = "0x7BBC3E653C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006D73 RID: 28019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D73")]
		[Address(RVA = "0x1BE683C", Offset = "0x1BE683C", VA = "0x7BBC3E683C")]
		private void OnRecruitItemClick(object[] data)
		{
		}

		// Token: 0x06006D74 RID: 28020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D74")]
		[Address(RVA = "0x1BE6B0C", Offset = "0x1BE6B0C", VA = "0x7BBC3E6B0C", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06006D75 RID: 28021 RVA: 0x0001EDB0 File Offset: 0x0001CFB0
		[Token(Token = "0x6006D75")]
		[Address(RVA = "0x1BE6C18", Offset = "0x1BE6C18", VA = "0x7BBC3E6C18")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006D76 RID: 28022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D76")]
		[Address(RVA = "0x1BE6C68", Offset = "0x1BE6C68", VA = "0x7BBC3E6C68", Slot = "28")]
		public override GameObject GetContentNode()
		{
			return null;
		}

		// Token: 0x06006D77 RID: 28023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D77")]
		[Address(RVA = "0x1BE6C94", Offset = "0x1BE6C94", VA = "0x7BBC3E6C94", Slot = "29")]
		public override GameObject GetEmptyNode()
		{
			return null;
		}

		// Token: 0x06006D78 RID: 28024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D78")]
		[Address(RVA = "0x1BE6CC0", Offset = "0x1BE6CC0", VA = "0x7BBC3E6CC0", Slot = "30")]
		public override UIScrollView GetMessageList()
		{
			return null;
		}

		// Token: 0x06006D79 RID: 28025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D79")]
		[Address(RVA = "0x1BE6CEC", Offset = "0x1BE6CEC", VA = "0x7BBC3E6CEC", Slot = "31")]
		public override void InitWidget(Transform parent)
		{
		}

		// Token: 0x06006D7A RID: 28026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D7A")]
		[Address(RVA = "0x1BE6D68", Offset = "0x1BE6D68", VA = "0x7BBC3E6D68", Slot = "32")]
		public override void RefreshContentNode()
		{
		}

		// Token: 0x06006D7B RID: 28027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D7B")]
		[Address(RVA = "0x1BE69CC", Offset = "0x1BE69CC", VA = "0x7BBC3E69CC")]
		private void RefreshMessageList()
		{
		}

		// Token: 0x06006D7C RID: 28028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D7C")]
		[Address(RVA = "0x1BE6D8C", Offset = "0x1BE6D8C", VA = "0x7BBC3E6D8C")]
		private void RefreshGroupInfo()
		{
		}

		// Token: 0x06006D7D RID: 28029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D7D")]
		[Address(RVA = "0x1BE728C", Offset = "0x1BE728C", VA = "0x7BBC3E728C")]
		private void OnRecruitClick()
		{
		}

		// Token: 0x06006D7E RID: 28030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D7E")]
		[Address(RVA = "0x1BE7760", Offset = "0x1BE7760", VA = "0x7BBC3E7760")]
		private void OnLeaveGroupBtnClick()
		{
		}

		// Token: 0x06006D7F RID: 28031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D7F")]
		[Address(RVA = "0x1BE77FC", Offset = "0x1BE77FC", VA = "0x7BBC3E77FC", Slot = "33")]
		private void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06006D80 RID: 28032 RVA: 0x0001EDC8 File Offset: 0x0001CFC8
		[Token(Token = "0x6006D80")]
		[Address(RVA = "0x1BE7904", Offset = "0x1BE7904", VA = "0x7BBC3E7904", Slot = "34")]
		private uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06006D81 RID: 28033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D81")]
		[Address(RVA = "0x1BE7968", Offset = "0x1BE7968", VA = "0x7BBC3E7968", Slot = "35")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06006D82 RID: 28034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D82")]
		[Address(RVA = "0x1BE79FC", Offset = "0x1BE79FC", VA = "0x7BBC3E79FC", Slot = "36")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06006D83 RID: 28035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D83")]
		[Address(RVA = "0x1BE7A2C", Offset = "0x1BE7A2C", VA = "0x7BBC3E7A2C")]
		public UIChatRecruitContainerController()
		{
		}

		// Token: 0x04008890 RID: 34960
		[Token(Token = "0x4008890")]
		[FieldOffset(Offset = "0x58")]
		private UIChatRecruitContainerView m_View;

		// Token: 0x04008891 RID: 34961
		[Token(Token = "0x4008891")]
		[FieldOffset(Offset = "0x60")]
		private UIModelGroup m_ModelGroup;

		// Token: 0x04008892 RID: 34962
		[Token(Token = "0x4008892")]
		[FieldOffset(Offset = "0x68")]
		private UIModelChat m_ModelChat;
	}
}
