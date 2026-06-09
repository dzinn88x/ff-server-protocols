using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using message;
using UnityEngine;

namespace COW
{
	// Token: 0x020014B0 RID: 5296
	[Token(Token = "0x20014B0")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ED53C", Offset = "0x10ED53C")]
	internal class UIHudBaseCSRoundResultController : UIBaseController
	{
		// Token: 0x060059D7 RID: 22999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059D7")]
		[Address(RVA = "0x189267C", Offset = "0x189267C", VA = "0x7BBC09267C")]
		public void SetBonusDetailsView(D|\u007FgF\u007Ft res)
		{
		}

		// Token: 0x060059D8 RID: 23000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059D8")]
		[Address(RVA = "0x1892AE4", Offset = "0x1892AE4", VA = "0x7BBC092AE4")]
		protected string GetDescriptionOfBonusType(kh{rwd\u0081 bonusType, params object[] param)
		{
			return null;
		}

		// Token: 0x060059D9 RID: 23001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059D9")]
		[Address(RVA = "0x1892E68", Offset = "0x1892E68", VA = "0x7BBC092E68")]
		public void SetRoundWinLoseReason(byte winReason)
		{
		}

		// Token: 0x060059DA RID: 23002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059DA")]
		[Address(RVA = "0x18933A8", Offset = "0x18933A8", VA = "0x7BBC0933A8")]
		public UIHudBaseCSRoundResultController()
		{
		}

		// Token: 0x04007D1F RID: 32031
		[Token(Token = "0x4007D1F")]
		[FieldOffset(Offset = "0x58")]
		protected UIModelMatch m_ModelMatch;

		// Token: 0x04007D20 RID: 32032
		[Token(Token = "0x4007D20")]
		[FieldOffset(Offset = "0x60")]
		protected List<GameObject> m_BonusItemList;

		// Token: 0x04007D21 RID: 32033
		[Token(Token = "0x4007D21")]
		[FieldOffset(Offset = "0x68")]
		protected GameObject bonusItem;

		// Token: 0x04007D22 RID: 32034
		[Token(Token = "0x4007D22")]
		[FieldOffset(Offset = "0x70")]
		protected UIGrid bonusGrid;

		// Token: 0x04007D23 RID: 32035
		[Token(Token = "0x4007D23")]
		[FieldOffset(Offset = "0x78")]
		protected UILabel LabelReason;
	}
}
