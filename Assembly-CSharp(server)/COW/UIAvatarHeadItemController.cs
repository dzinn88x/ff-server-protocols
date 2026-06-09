using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020016A7 RID: 5799
	[Token(Token = "0x20016A7")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F087C", Offset = "0x10F087C")]
	public class UIAvatarHeadItemController : UIEasyListItemController
	{
		// Token: 0x060069BC RID: 27068 RVA: 0x0001DF40 File Offset: 0x0001C140
		[Token(Token = "0x60069BC")]
		[Address(RVA = "0x1B25090", Offset = "0x1B25090", VA = "0x7BBC325090")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060069BD RID: 27069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069BD")]
		[Address(RVA = "0x1B250E0", Offset = "0x1B250E0", VA = "0x7BBC3250E0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060069BE RID: 27070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069BE")]
		[Address(RVA = "0x1B2529C", Offset = "0x1B2529C", VA = "0x7BBC32529C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060069BF RID: 27071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069BF")]
		[Address(RVA = "0x1B252A4", Offset = "0x1B252A4", VA = "0x7BBC3252A4", Slot = "31")]
		public override void OnItemBtnSelect()
		{
		}

		// Token: 0x060069C0 RID: 27072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069C0")]
		[Address(RVA = "0x1B25418", Offset = "0x1B25418", VA = "0x7BBC325418", Slot = "32")]
		public override void OnItemBtnUnSelect()
		{
		}

		// Token: 0x060069C1 RID: 27073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069C1")]
		[Address(RVA = "0x1B25480", Offset = "0x1B25480", VA = "0x7BBC325480")]
		public void ShowDebrisCnt()
		{
		}

		// Token: 0x060069C2 RID: 27074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069C2")]
		[Address(RVA = "0x1B2548C", Offset = "0x1B2548C", VA = "0x7BBC32548C")]
		public void HideName()
		{
		}

		// Token: 0x060069C3 RID: 27075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069C3")]
		[Address(RVA = "0x1B25498", Offset = "0x1B25498", VA = "0x7BBC325498", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x060069C4 RID: 27076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069C4")]
		[Address(RVA = "0x1B256E8", Offset = "0x1B256E8", VA = "0x7BBC3256E8")]
		public void RefreshLevelUpEffect()
		{
		}

		// Token: 0x060069C5 RID: 27077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069C5")]
		[Address(RVA = "0x1B25850", Offset = "0x1B25850", VA = "0x7BBC325850")]
		public UIAvatarHeadItemController()
		{
		}

		// Token: 0x04008681 RID: 34433
		[Token(Token = "0x4008681")]
		[FieldOffset(Offset = "0x70")]
		private UIAvatarHeadItemView m_View;

		// Token: 0x04008682 RID: 34434
		[Token(Token = "0x4008682")]
		[FieldOffset(Offset = "0x78")]
		private AvatarProfile m_Itemdata;

		// Token: 0x04008683 RID: 34435
		[Token(Token = "0x4008683")]
		[FieldOffset(Offset = "0x80")]
		private bool m_ShowDebrisCnt;

		// Token: 0x04008684 RID: 34436
		[Token(Token = "0x4008684")]
		[FieldOffset(Offset = "0x81")]
		private bool m_HideName;
	}
}
