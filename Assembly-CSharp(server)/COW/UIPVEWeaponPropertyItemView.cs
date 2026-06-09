using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001637 RID: 5687
	[Token(Token = "0x2001637")]
	public class UIPVEWeaponPropertyItemView : MonoBehaviour
	{
		// Token: 0x06006670 RID: 26224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006670")]
		[Address(RVA = "0x16E8F68", Offset = "0x16E8F68", VA = "0x7BBBEE8F68")]
		public void SetViewData(UIPVEWeaponPropertyController.PVEProperty propertyData, bool showDot)
		{
		}

		// Token: 0x06006671 RID: 26225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006671")]
		[Address(RVA = "0x16E95B8", Offset = "0x16E95B8", VA = "0x7BBBEE95B8")]
		public UIPVEWeaponPropertyItemView()
		{
		}

		// Token: 0x0400842F RID: 33839
		[Token(Token = "0x400842F")]
		[FieldOffset(Offset = "0x18")]
		public UILabel Description;

		// Token: 0x04008430 RID: 33840
		[Token(Token = "0x4008430")]
		[FieldOffset(Offset = "0x20")]
		public UILabel PropertyValue;

		// Token: 0x04008431 RID: 33841
		[Token(Token = "0x4008431")]
		[FieldOffset(Offset = "0x28")]
		public GameObject DotObject;

		// Token: 0x04008432 RID: 33842
		[Token(Token = "0x4008432")]
		[FieldOffset(Offset = "0x30")]
		public GameObject Arrow1;

		// Token: 0x04008433 RID: 33843
		[Token(Token = "0x4008433")]
		[FieldOffset(Offset = "0x38")]
		public GameObject Arrow2;

		// Token: 0x04008434 RID: 33844
		[Token(Token = "0x4008434")]
		[FieldOffset(Offset = "0x40")]
		public GameObject Arrow3;
	}
}
