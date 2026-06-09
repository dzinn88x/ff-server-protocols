using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001AF5 RID: 6901
	[Token(Token = "0x2001AF5")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F8F84", Offset = "0x10F8F84")]
	public class UIPetItemController : UIEasyListItemController, IUIModelDataChangeObserver
	{
		// Token: 0x06009281 RID: 37505 RVA: 0x00027018 File Offset: 0x00025218
		[Token(Token = "0x6009281")]
		[Address(RVA = "0x20DF288", Offset = "0x20DF288", VA = "0x7BBC8DF288")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009282 RID: 37506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009282")]
		[Address(RVA = "0x20DF2D8", Offset = "0x20DF2D8", VA = "0x7BBC8DF2D8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009283 RID: 37507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009283")]
		[Address(RVA = "0x20DF4D4", Offset = "0x20DF4D4", VA = "0x7BBC8DF4D4", Slot = "31")]
		public override void OnItemBtnSelect()
		{
		}

		// Token: 0x06009284 RID: 37508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009284")]
		[Address(RVA = "0x20DFC5C", Offset = "0x20DFC5C", VA = "0x7BBC8DFC5C", Slot = "32")]
		public override void OnItemBtnUnSelect()
		{
		}

		// Token: 0x06009285 RID: 37509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009285")]
		[Address(RVA = "0x20DF9A8", Offset = "0x20DF9A8", VA = "0x7BBC8DF9A8")]
		public void SetHighLightBGState(bool show)
		{
		}

		// Token: 0x06009286 RID: 37510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009286")]
		[Address(RVA = "0x20DFC88", Offset = "0x20DFC88", VA = "0x7BBC8DFC88", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06009287 RID: 37511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009287")]
		[Address(RVA = "0x20DFD60", Offset = "0x20DFD60", VA = "0x7BBC8DFD60")]
		public void RefreshData()
		{
		}

		// Token: 0x06009288 RID: 37512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009288")]
		[Address(RVA = "0x20DFA38", Offset = "0x20DFA38", VA = "0x7BBC8DFA38")]
		public void CheckNewTag(params object[] param)
		{
		}

		// Token: 0x06009289 RID: 37513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009289")]
		[Address(RVA = "0x20E0000", Offset = "0x20E0000", VA = "0x7BBC8E0000")]
		public void SetCarryShow(PetInfo info)
		{
		}

		// Token: 0x0600928A RID: 37514 RVA: 0x00027030 File Offset: 0x00025230
		[Token(Token = "0x600928A")]
		[Address(RVA = "0x20E00AC", Offset = "0x20E00AC", VA = "0x7BBC8E00AC", Slot = "35")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600928B RID: 37515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600928B")]
		[Address(RVA = "0x20E00F0", Offset = "0x20E00F0", VA = "0x7BBC8E00F0", Slot = "34")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600928C RID: 37516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600928C")]
		[Address(RVA = "0x20E02F8", Offset = "0x20E02F8", VA = "0x7BBC8E02F8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600928D RID: 37517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600928D")]
		[Address(RVA = "0x20E0430", Offset = "0x20E0430", VA = "0x7BBC8E0430")]
		public UIPetItemController()
		{
		}

		// Token: 0x04009CFE RID: 40190
		[Token(Token = "0x4009CFE")]
		[FieldOffset(Offset = "0x70")]
		private UIPetCommonItemView m_View;

		// Token: 0x04009CFF RID: 40191
		[Token(Token = "0x4009CFF")]
		[FieldOffset(Offset = "0x78")]
		private PetInfo pet_info;

		// Token: 0x04009D00 RID: 40192
		[Token(Token = "0x4009D00")]
		[FieldOffset(Offset = "0x80")]
		private bool isSelected;
	}
}
