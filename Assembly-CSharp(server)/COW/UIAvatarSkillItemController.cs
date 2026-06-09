using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020016C7 RID: 5831
	[Token(Token = "0x20016C7")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F0C2C", Offset = "0x10F0C2C")]
	public class UIAvatarSkillItemController : UIEasyListItemController
	{
		// Token: 0x06006B1B RID: 27419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B1B")]
		[Address(RVA = "0x1E4825C", Offset = "0x1E4825C", VA = "0x7BBC64825C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006B1C RID: 27420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B1C")]
		[Address(RVA = "0x1E48500", Offset = "0x1E48500", VA = "0x7BBC648500", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006B1D RID: 27421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B1D")]
		[Address(RVA = "0x1E485CC", Offset = "0x1E485CC", VA = "0x7BBC6485CC")]
		private void OnLevelClick()
		{
		}

		// Token: 0x06006B1E RID: 27422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B1E")]
		[Address(RVA = "0x1E48798", Offset = "0x1E48798", VA = "0x7BBC648798")]
		private void OnTipsClick()
		{
		}

		// Token: 0x06006B1F RID: 27423 RVA: 0x0001E558 File Offset: 0x0001C758
		[Token(Token = "0x6006B1F")]
		[Address(RVA = "0x1E49B60", Offset = "0x1E49B60", VA = "0x7BBC649B60")]
		private bool CheckHasTips(AvatarProfile profile)
		{
			return default(bool);
		}

		// Token: 0x06006B20 RID: 27424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B20")]
		[Address(RVA = "0x1E49BD4", Offset = "0x1E49BD4", VA = "0x7BBC649BD4")]
		private void OnUpdateRedTips(params object[] data)
		{
		}

		// Token: 0x06006B21 RID: 27425 RVA: 0x0001E570 File Offset: 0x0001C770
		[Token(Token = "0x6006B21")]
		[Address(RVA = "0x1E49C28", Offset = "0x1E49C28", VA = "0x7BBC649C28")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006B22 RID: 27426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B22")]
		[Address(RVA = "0x1E49C78", Offset = "0x1E49C78", VA = "0x7BBC649C78", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06006B23 RID: 27427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B23")]
		[Address(RVA = "0x1E4B454", Offset = "0x1E4B454", VA = "0x7BBC64B454", Slot = "31")]
		public override void OnItemBtnSelect()
		{
		}

		// Token: 0x06006B24 RID: 27428 RVA: 0x0001E588 File Offset: 0x0001C788
		[Token(Token = "0x6006B24")]
		[Address(RVA = "0x1E4A84C", Offset = "0x1E4A84C", VA = "0x7BBC64A84C")]
		private uint GetAvatarIdBySkillId(uint _skillid)
		{
			return 0U;
		}

		// Token: 0x06006B25 RID: 27429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B25")]
		[Address(RVA = "0x1E4BC30", Offset = "0x1E4BC30", VA = "0x7BBC64BC30")]
		public UIAvatarSkillItemController()
		{
		}

		// Token: 0x04008723 RID: 34595
		[Token(Token = "0x4008723")]
		[FieldOffset(Offset = "0x70")]
		private SkillInfo m_Data;

		// Token: 0x04008724 RID: 34596
		[Token(Token = "0x4008724")]
		[FieldOffset(Offset = "0x78")]
		private UIAvatarSkillItemView m_View;

		// Token: 0x04008725 RID: 34597
		[Token(Token = "0x4008725")]
		[FieldOffset(Offset = "0x80")]
		private UIAvatarSkillSlotController slotctrl;

		// Token: 0x04008726 RID: 34598
		[Token(Token = "0x4008726")]
		[FieldOffset(Offset = "0x88")]
		private bool m_isActiveSkill;

		// Token: 0x04008727 RID: 34599
		[Token(Token = "0x4008727")]
		[FieldOffset(Offset = "0x90")]
		private AvatarSkillData m_SkillData;

		// Token: 0x04008728 RID: 34600
		[Token(Token = "0x4008728")]
		[FieldOffset(Offset = "0x98")]
		private AvatarProfile m_Profile;

		// Token: 0x04008729 RID: 34601
		[Token(Token = "0x4008729")]
		[FieldOffset(Offset = "0xA0")]
		private int m_MaxLevel;

		// Token: 0x0400872A RID: 34602
		[Token(Token = "0x400872A")]
		[FieldOffset(Offset = "0xA4")]
		private int m_Index;
	}
}
