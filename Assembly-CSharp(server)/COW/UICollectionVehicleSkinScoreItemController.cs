using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200173F RID: 5951
	[Token(Token = "0x200173F")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F1CE4", Offset = "0x10F1CE4")]
	internal class UICollectionVehicleSkinScoreItemController : UIBaseController
	{
		// Token: 0x06006FED RID: 28653 RVA: 0x0001F5F0 File Offset: 0x0001D7F0
		[Token(Token = "0x6006FED")]
		[Address(RVA = "0x20AD85C", Offset = "0x20AD85C", VA = "0x7BBC8AD85C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006FEE RID: 28654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FEE")]
		[Address(RVA = "0x20AD8AC", Offset = "0x20AD8AC", VA = "0x7BBC8AD8AC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006FEF RID: 28655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FEF")]
		[Address(RVA = "0x20ADB8C", Offset = "0x20ADB8C", VA = "0x7BBC8ADB8C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006FF0 RID: 28656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FF0")]
		[Address(RVA = "0x20ADB94", Offset = "0x20ADB94", VA = "0x7BBC8ADB94")]
		public void SetUIData(string name, int scoreVal)
		{
		}

		// Token: 0x06006FF1 RID: 28657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FF1")]
		[Address(RVA = "0x20ADEE4", Offset = "0x20ADEE4", VA = "0x7BBC8ADEE4")]
		public UICollectionVehicleSkinScoreItemController()
		{
		}

		// Token: 0x040089E2 RID: 35298
		[Token(Token = "0x40089E2")]
		[FieldOffset(Offset = "0x58")]
		private UICollectionVehicleSkinScoreItemView m_View;

		// Token: 0x040089E3 RID: 35299
		[Token(Token = "0x40089E3")]
		[FieldOffset(Offset = "0x60")]
		private List<GameObject> m_UpIconList;

		// Token: 0x040089E4 RID: 35300
		[Token(Token = "0x40089E4")]
		[FieldOffset(Offset = "0x68")]
		private List<GameObject> m_DownIconList;

		// Token: 0x040089E5 RID: 35301
		[Token(Token = "0x40089E5")]
		[FieldOffset(Offset = "0x70")]
		private Color COLOR_SCORE_RED;

		// Token: 0x040089E6 RID: 35302
		[Token(Token = "0x40089E6")]
		[FieldOffset(Offset = "0x80")]
		private Color COLOR_SCORE_GREEN;
	}
}
