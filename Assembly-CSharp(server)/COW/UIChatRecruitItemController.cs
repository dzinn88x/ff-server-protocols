using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001700 RID: 5888
	[Token(Token = "0x2001700")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F13D4", Offset = "0x10F13D4")]
	public class UIChatRecruitItemController : UIEasyListItemController
	{
		// Token: 0x06006D84 RID: 28036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D84")]
		[Address(RVA = "0x1BE7E1C", Offset = "0x1BE7E1C", VA = "0x7BBC3E7E1C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006D85 RID: 28037 RVA: 0x0001EDE0 File Offset: 0x0001CFE0
		[Token(Token = "0x6006D85")]
		[Address(RVA = "0x1BE7FD0", Offset = "0x1BE7FD0", VA = "0x7BBC3E7FD0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006D86 RID: 28038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D86")]
		[Address(RVA = "0x1BE8020", Offset = "0x1BE8020", VA = "0x7BBC3E8020", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06006D87 RID: 28039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D87")]
		[Address(RVA = "0x1BE8A10", Offset = "0x1BE8A10", VA = "0x7BBC3E8A10", Slot = "31")]
		public override void OnItemBtnSelect()
		{
		}

		// Token: 0x06006D88 RID: 28040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D88")]
		[Address(RVA = "0x1BE8B20", Offset = "0x1BE8B20", VA = "0x7BBC3E8B20")]
		public UIChatRecruitItemController()
		{
		}

		// Token: 0x04008893 RID: 34963
		[Token(Token = "0x4008893")]
		[FieldOffset(Offset = "0x70")]
		private UIChatRecruitItemView m_View;

		// Token: 0x04008894 RID: 34964
		[Token(Token = "0x4008894")]
		[FieldOffset(Offset = "0x78")]
		private MessageInfo m_InfoData;

		// Token: 0x04008895 RID: 34965
		[Token(Token = "0x4008895")]
		[FieldOffset(Offset = "0x80")]
		private FastGroupInvite m_GroupRecruit;

		// Token: 0x04008896 RID: 34966
		[Token(Token = "0x4008896")]
		private const string LADDER_BG = "FF_UI_chatbg_01";

		// Token: 0x04008897 RID: 34967
		[Token(Token = "0x4008897")]
		private const string NORMAL_BG = "FF_UI_chatbg_02";

		// Token: 0x04008898 RID: 34968
		[Token(Token = "0x4008898")]
		[FieldOffset(Offset = "0x88")]
		private UIBaseProfileInfoController m_BaseProfileCtrl;
	}
}
