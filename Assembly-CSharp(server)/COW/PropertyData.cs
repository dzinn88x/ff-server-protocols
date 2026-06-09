using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200108B RID: 4235
	[Token(Token = "0x200108B")]
	public class PropertyData
	{
		// Token: 0x0600411A RID: 16666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600411A")]
		[Address(RVA = "0x174F9F4", Offset = "0x174F9F4", VA = "0x7BBBF4F9F4")]
		public PropertyData()
		{
		}

		// Token: 0x0600411B RID: 16667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600411B")]
		[Address(RVA = "0x174FAC0", Offset = "0x174FAC0", VA = "0x7BBBF4FAC0")]
		public PropertyData(ResourceID pLeft, ResourceID pRight, ResourceID pRoot, ResourceID pHead, [Optional] Vector3 pLeftScale)
		{
		}

		// Token: 0x0600411C RID: 16668 RVA: 0x00013FB0 File Offset: 0x000121B0
		[Token(Token = "0x600411C")]
		[Address(RVA = "0x174FC2C", Offset = "0x174FC2C", VA = "0x7BBBF4FC2C")]
		public bool Valid()
		{
			return default(bool);
		}

		// Token: 0x0400507E RID: 20606
		[Token(Token = "0x400507E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ResourceID m_PropIDRight;

		// Token: 0x0400507F RID: 20607
		[Token(Token = "0x400507F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public ResourceID m_PropIDLeft;

		// Token: 0x04005080 RID: 20608
		[Token(Token = "0x4005080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ResourceID m_PropIDRoot;

		// Token: 0x04005081 RID: 20609
		[Token(Token = "0x4005081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ResourceID m_PropIDHead;

		// Token: 0x04005082 RID: 20610
		[Token(Token = "0x4005082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 m_PropLeftScale;
	}
}
