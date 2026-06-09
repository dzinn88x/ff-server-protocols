using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020017CB RID: 6091
	[Token(Token = "0x20017CB")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F2C8C", Offset = "0x10F2C8C")]
	public class UIFriendRelationshipGraphContainer : MonoBehaviour
	{
		// Token: 0x06007516 RID: 29974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007516")]
		[Address(RVA = "0x1593614", Offset = "0x1593614", VA = "0x7BBBD93614")]
		public UIFriendRelationshipGraphContainer()
		{
		}

		// Token: 0x04008CAE RID: 36014
		[Token(Token = "0x4008CAE")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 HeadIconSize;

		// Token: 0x04008CAF RID: 36015
		[Token(Token = "0x4008CAF")]
		[FieldOffset(Offset = "0x20")]
		public Vector2 HeadBGSize;

		// Token: 0x04008CB0 RID: 36016
		[Token(Token = "0x4008CB0")]
		[FieldOffset(Offset = "0x28")]
		public int NameFontSize;

		// Token: 0x04008CB1 RID: 36017
		[Token(Token = "0x4008CB1")]
		[FieldOffset(Offset = "0x2C")]
		public Color NameFontColor;

		// Token: 0x04008CB2 RID: 36018
		[Token(Token = "0x4008CB2")]
		[FieldOffset(Offset = "0x3C")]
		public Color ArrowColor;

		// Token: 0x04008CB3 RID: 36019
		[Token(Token = "0x4008CB3")]
		[FieldOffset(Offset = "0x4C")]
		public EUIFriendRelationshipType RelationshipType;
	}
}
