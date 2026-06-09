using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001709 RID: 5897
	[Token(Token = "0x2001709")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F14E4", Offset = "0x10F14E4")]
	public class UIChatWhisperNameItemController : UIEasyListItemController, ITipsDelegate
	{
		// Token: 0x06006DC0 RID: 28096 RVA: 0x0001EEE8 File Offset: 0x0001D0E8
		[Token(Token = "0x6006DC0")]
		[Address(RVA = "0x1BEFE00", Offset = "0x1BEFE00", VA = "0x7BBC3EFE00")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006DC1 RID: 28097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DC1")]
		[Address(RVA = "0x1BEFE50", Offset = "0x1BEFE50", VA = "0x7BBC3EFE50", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006DC2 RID: 28098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DC2")]
		[Address(RVA = "0x1BF0024", Offset = "0x1BF0024", VA = "0x7BBC3F0024")]
		private void OnDeleteClick()
		{
		}

		// Token: 0x06006DC3 RID: 28099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DC3")]
		[Address(RVA = "0x1BF013C", Offset = "0x1BF013C", VA = "0x7BBC3F013C", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06006DC4 RID: 28100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DC4")]
		[Address(RVA = "0x1BF01D4", Offset = "0x1BF01D4", VA = "0x7BBC3F01D4", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06006DC5 RID: 28101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DC5")]
		[Address(RVA = "0x1BF08AC", Offset = "0x1BF08AC", VA = "0x7BBC3F08AC", Slot = "31")]
		public override void OnItemBtnSelect()
		{
		}

		// Token: 0x06006DC6 RID: 28102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DC6")]
		[Address(RVA = "0x1BF09E8", Offset = "0x1BF09E8", VA = "0x7BBC3F09E8", Slot = "34")]
		private void OnTipsDataChange(ETipsType type, int num)
		{
		}

		// Token: 0x06006DC7 RID: 28103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DC7")]
		[Address(RVA = "0x1BF077C", Offset = "0x1BF077C", VA = "0x7BBC3F077C")]
		private void RefreshUnreadTips()
		{
		}

		// Token: 0x06006DC8 RID: 28104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DC8")]
		[Address(RVA = "0x1BF09F8", Offset = "0x1BF09F8", VA = "0x7BBC3F09F8")]
		public UIChatWhisperNameItemController()
		{
		}

		// Token: 0x040088B3 RID: 34995
		[Token(Token = "0x40088B3")]
		[FieldOffset(Offset = "0x70")]
		private UIChatWhisperNameItemView m_View;

		// Token: 0x040088B4 RID: 34996
		[Token(Token = "0x40088B4")]
		[FieldOffset(Offset = "0x78")]
		private ChatWhisperNameData m_WhisperData;
	}
}
