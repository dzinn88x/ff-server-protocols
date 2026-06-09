using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001AF8 RID: 6904
	[Token(Token = "0x2001AF8")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F902C", Offset = "0x10F902C")]
	public class UIPetSkillGridController : UIBaseController, IEasyList
	{
		// Token: 0x0600929C RID: 37532 RVA: 0x00027078 File Offset: 0x00025278
		[Token(Token = "0x600929C")]
		[Address(RVA = "0x20E0E54", Offset = "0x20E0E54", VA = "0x7BBC8E0E54")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600929D RID: 37533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600929D")]
		[Address(RVA = "0x20E0EA4", Offset = "0x20E0EA4", VA = "0x7BBC8E0EA4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600929E RID: 37534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600929E")]
		[Address(RVA = "0x20E1038", Offset = "0x20E1038", VA = "0x7BBC8E1038", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600929F RID: 37535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600929F")]
		[Address(RVA = "0x20E1104", Offset = "0x20E1104", VA = "0x7BBC8E1104", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x060092A0 RID: 37536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092A0")]
		[Address(RVA = "0x20DC7F8", Offset = "0x20DC7F8", VA = "0x7BBC8DC7F8")]
		public void SetSelectedSkillInfo(List<PetSkillConfigInfo> dataShowList)
		{
		}

		// Token: 0x060092A1 RID: 37537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092A1")]
		[Address(RVA = "0x20E1280", Offset = "0x20E1280", VA = "0x7BBC8E1280")]
		private void ShowSkillList()
		{
		}

		// Token: 0x060092A2 RID: 37538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092A2")]
		[Address(RVA = "0x20E1510", Offset = "0x20E1510", VA = "0x7BBC8E1510")]
		private void ShowSelectSkillList(params object[] param)
		{
		}

		// Token: 0x060092A3 RID: 37539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092A3")]
		[Address(RVA = "0x20DC728", Offset = "0x20DC728", VA = "0x7BBC8DC728")]
		public void ShowCurrentSelectedSkill(PetSkillConfigInfo data)
		{
		}

		// Token: 0x060092A4 RID: 37540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092A4")]
		[Address(RVA = "0x20E1710", Offset = "0x20E1710", VA = "0x7BBC8E1710")]
		public void OnClickMask()
		{
		}

		// Token: 0x060092A5 RID: 37541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092A5")]
		[Address(RVA = "0x20DC7C4", Offset = "0x20DC7C4", VA = "0x7BBC8DC7C4")]
		public void ShowNoItemTips(bool isUnlock)
		{
		}

		// Token: 0x060092A6 RID: 37542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60092A6")]
		[Address(RVA = "0x20E1BEC", Offset = "0x20E1BEC", VA = "0x7BBC8E1BEC", Slot = "28")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x060092A7 RID: 37543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092A7")]
		[Address(RVA = "0x20E1C80", Offset = "0x20E1C80", VA = "0x7BBC8E1C80", Slot = "29")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x060092A8 RID: 37544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092A8")]
		[Address(RVA = "0x20E1CB0", Offset = "0x20E1CB0", VA = "0x7BBC8E1CB0")]
		public UIPetSkillGridController()
		{
		}

		// Token: 0x04009D05 RID: 40197
		[Token(Token = "0x4009D05")]
		private const int ALL_GRID_COLUMN = 1;

		// Token: 0x04009D06 RID: 40198
		[Token(Token = "0x4009D06")]
		[FieldOffset(Offset = "0x58")]
		private UIPetSkillScrollViewView m_View;

		// Token: 0x04009D07 RID: 40199
		[Token(Token = "0x4009D07")]
		[FieldOffset(Offset = "0x60")]
		private UIPetSkillItemController m_CurrentSkillItemCtrl;

		// Token: 0x04009D08 RID: 40200
		[Token(Token = "0x4009D08")]
		[FieldOffset(Offset = "0x68")]
		private List<PetSkillConfigInfo> m_NeedShowConfigList;

		// Token: 0x04009D09 RID: 40201
		[Token(Token = "0x4009D09")]
		[FieldOffset(Offset = "0x70")]
		private uint m_CurrentSelectedSkillID;
	}
}
