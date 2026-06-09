using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001393 RID: 5011
	[Token(Token = "0x2001393")]
	public class UIDiceGameGridItemController : UIBaseController
	{
		// Token: 0x060050D1 RID: 20689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050D1")]
		[Address(RVA = "0x21F9CFC", Offset = "0x21F9CFC", VA = "0x7BBC9F9CFC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060050D2 RID: 20690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050D2")]
		[Address(RVA = "0x21F9F50", Offset = "0x21F9F50", VA = "0x7BBC9F9F50")]
		public void InitIndex(int Inx)
		{
		}

		// Token: 0x060050D3 RID: 20691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050D3")]
		[Address(RVA = "0x21F9F58", Offset = "0x21F9F58", VA = "0x7BBC9F9F58")]
		public void InitType(EDiceGameGridType type)
		{
		}

		// Token: 0x060050D4 RID: 20692 RVA: 0x000187C8 File Offset: 0x000169C8
		[Token(Token = "0x60050D4")]
		[Address(RVA = "0x21FA7E8", Offset = "0x21FA7E8", VA = "0x7BBC9FA7E8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060050D5 RID: 20693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050D5")]
		[Address(RVA = "0x21FA720", Offset = "0x21FA720", VA = "0x7BBC9FA720")]
		public void SetItemVisible(bool b)
		{
		}

		// Token: 0x060050D6 RID: 20694 RVA: 0x000187E0 File Offset: 0x000169E0
		[Token(Token = "0x60050D6")]
		[Address(RVA = "0x21FA838", Offset = "0x21FA838", VA = "0x7BBC9FA838")]
		public int GetIndex()
		{
			return 0;
		}

		// Token: 0x060050D7 RID: 20695 RVA: 0x000187F8 File Offset: 0x000169F8
		[Token(Token = "0x60050D7")]
		[Address(RVA = "0x21FA840", Offset = "0x21FA840", VA = "0x7BBC9FA840")]
		public EDiceGameGridType GetGridType()
		{
			return EDiceGameGridType.None;
		}

		// Token: 0x060050D8 RID: 20696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050D8")]
		[Address(RVA = "0x21F9F84", Offset = "0x21F9F84", VA = "0x7BBC9F9F84")]
		private void HandleItemType(EDiceGameGridType t)
		{
		}

		// Token: 0x060050D9 RID: 20697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050D9")]
		[Address(RVA = "0x21FA848", Offset = "0x21FA848", VA = "0x7BBC9FA848")]
		public UIDiceGameGridItemController()
		{
		}

		// Token: 0x0400775D RID: 30557
		[Token(Token = "0x400775D")]
		[FieldOffset(Offset = "0x58")]
		private UIDiceGameGridItemView m_View;

		// Token: 0x0400775E RID: 30558
		[Token(Token = "0x400775E")]
		[FieldOffset(Offset = "0x60")]
		private EDiceGameGridType m_Type;

		// Token: 0x0400775F RID: 30559
		[Token(Token = "0x400775F")]
		[FieldOffset(Offset = "0x68")]
		private GameObject m_ShouldHideSprWhenPlayerIn;

		// Token: 0x04007760 RID: 30560
		[Token(Token = "0x4007760")]
		[FieldOffset(Offset = "0x70")]
		private int m_Index;

		// Token: 0x04007761 RID: 30561
		[Token(Token = "0x4007761")]
		[FieldOffset(Offset = "0x74")]
		private bool m_HadPlayerMoveIn;
	}
}
