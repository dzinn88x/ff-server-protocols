using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x0200100D RID: 4109
	[Token(Token = "0x200100D")]
	public class SetRelativeDepth : MonoBehaviour
	{
		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x06003DA5 RID: 15781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000728")]
		private List<Renderer> CachedChildrenRenderers
		{
			[Token(Token = "0x6003DA5")]
			[Address(RVA = "0x2492A0C", Offset = "0x2492A0C", VA = "0x7BBCC92A0C")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003DA6 RID: 15782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DA6")]
		[Address(RVA = "0x2492BB8", Offset = "0x2492BB8", VA = "0x7BBCC92BB8")]
		private void Start()
		{
		}

		// Token: 0x06003DA7 RID: 15783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DA7")]
		[Address(RVA = "0x2492BC0", Offset = "0x2492BC0", VA = "0x7BBCC92BC0")]
		private void OnValidate()
		{
		}

		// Token: 0x06003DA8 RID: 15784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DA8")]
		[Address(RVA = "0x2492BC8", Offset = "0x2492BC8", VA = "0x7BBCC92BC8")]
		private void LateUpdate()
		{
		}

		// Token: 0x06003DA9 RID: 15785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DA9")]
		[Address(RVA = "0x2492008", Offset = "0x2492008", VA = "0x7BBCC92008")]
		public void Refresh(bool isForce = false)
		{
		}

		// Token: 0x06003DAA RID: 15786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DAA")]
		[Address(RVA = "0x2492BD0", Offset = "0x2492BD0", VA = "0x7BBCC92BD0")]
		public SetRelativeDepth()
		{
		}

		// Token: 0x04004E62 RID: 20066
		[Token(Token = "0x4004E62")]
		[FieldOffset(Offset = "0x18")]
		public UIWidget widget;

		// Token: 0x04004E63 RID: 20067
		[Token(Token = "0x4004E63")]
		[FieldOffset(Offset = "0x20")]
		public SetRelativeDepth.PositionType position;

		// Token: 0x04004E64 RID: 20068
		[Token(Token = "0x4004E64")]
		[FieldOffset(Offset = "0x24")]
		public bool m_ChangeChildren;

		// Token: 0x04004E65 RID: 20069
		[Token(Token = "0x4004E65")]
		[FieldOffset(Offset = "0x28")]
		private int sortingOrder;

		// Token: 0x04004E66 RID: 20070
		[Token(Token = "0x4004E66")]
		[FieldOffset(Offset = "0x2C")]
		private int renderQueue;

		// Token: 0x04004E67 RID: 20071
		[Token(Token = "0x4004E67")]
		private const bool updateEveryFrame = true;

		// Token: 0x04004E68 RID: 20072
		[Token(Token = "0x4004E68")]
		[FieldOffset(Offset = "0x30")]
		private List<Renderer> _CachedChildrenRenderers;

		// Token: 0x0200100E RID: 4110
		[Token(Token = "0x200100E")]
		public enum PositionType
		{
			// Token: 0x04004E6A RID: 20074
			[Token(Token = "0x4004E6A")]
			Above,
			// Token: 0x04004E6B RID: 20075
			[Token(Token = "0x4004E6B")]
			Behind
		}
	}
}
