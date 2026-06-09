using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B35 RID: 6965
	[Token(Token = "0x2001B35")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F9794", Offset = "0x10F9794")]
	public class UIRankCardItemController : UIEasyListItemController
	{
		// Token: 0x0600958B RID: 38283 RVA: 0x000278B8 File Offset: 0x00025AB8
		[Token(Token = "0x600958B")]
		[Address(RVA = "0x1E09368", Offset = "0x1E09368", VA = "0x7BBC609368")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600958C RID: 38284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600958C")]
		[Address(RVA = "0x1E093B8", Offset = "0x1E093B8", VA = "0x7BBC6093B8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600958D RID: 38285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600958D")]
		[Address(RVA = "0x1E0954C", Offset = "0x1E0954C", VA = "0x7BBC60954C", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x0600958E RID: 38286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600958E")]
		[Address(RVA = "0x1E0981C", Offset = "0x1E0981C", VA = "0x7BBC60981C", Slot = "31")]
		public override void OnItemBtnSelect()
		{
		}

		// Token: 0x0600958F RID: 38287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600958F")]
		[Address(RVA = "0x1E098D4", Offset = "0x1E098D4", VA = "0x7BBC6098D4", Slot = "32")]
		public override void OnItemBtnUnSelect()
		{
		}

		// Token: 0x06009590 RID: 38288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009590")]
		[Address(RVA = "0x1E0993C", Offset = "0x1E0993C", VA = "0x7BBC60993C")]
		private void OnInfoBtnClick()
		{
		}

		// Token: 0x06009591 RID: 38289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009591")]
		[Address(RVA = "0x1E09AD0", Offset = "0x1E09AD0", VA = "0x7BBC609AD0")]
		private void OnClickRankCardItem()
		{
		}

		// Token: 0x06009592 RID: 38290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009592")]
		[Address(RVA = "0x1E09C08", Offset = "0x1E09C08", VA = "0x7BBC609C08")]
		public UIRankCardItemController()
		{
		}

		// Token: 0x04009EAF RID: 40623
		[Token(Token = "0x4009EAF")]
		[FieldOffset(Offset = "0x70")]
		private UIRankCardItemView m_View;

		// Token: 0x04009EB0 RID: 40624
		[Token(Token = "0x4009EB0")]
		[FieldOffset(Offset = "0x78")]
		private BaseItemInfo m_data;
	}
}
