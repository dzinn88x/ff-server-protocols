using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002126 RID: 8486
	[Token(Token = "0x2002126")]
	public class UIBundleItemView : UIBaseView
	{
		// Token: 0x0600BD5C RID: 48476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD5C")]
		[Address(RVA = "0x1C1EAB0", Offset = "0x1C1EAB0", VA = "0x7BBC41EAB0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD5D RID: 48477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD5D")]
		[Address(RVA = "0x1C1EC88", Offset = "0x1C1EC88", VA = "0x7BBC41EC88")]
		public UIBundleItemView()
		{
		}

		// Token: 0x0400C2FD RID: 49917
		[Token(Token = "0x400C2FD")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ItemBtn;

		// Token: 0x0400C2FE RID: 49918
		[Token(Token = "0x400C2FE")]
		[FieldOffset(Offset = "0x28")]
		public GameObject Owned;

		// Token: 0x0400C2FF RID: 49919
		[Token(Token = "0x400C2FF")]
		[FieldOffset(Offset = "0x30")]
		public UILabel OwnedLabel;

		// Token: 0x0400C300 RID: 49920
		[Token(Token = "0x400C300")]
		[FieldOffset(Offset = "0x38")]
		public GameObject Descargar;

		// Token: 0x0400C301 RID: 49921
		[Token(Token = "0x400C301")]
		[FieldOffset(Offset = "0x40")]
		public GameObject BGGrey;

		// Token: 0x0400C302 RID: 49922
		[Token(Token = "0x400C302")]
		[FieldOffset(Offset = "0x48")]
		public GameObject BGSelected;
	}
}
