using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x0200100C RID: 4108
	[Token(Token = "0x200100C")]
	public class SetPanelClip : MonoBehaviour
	{
		// Token: 0x06003D9F RID: 15775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D9F")]
		[Address(RVA = "0x2491740", Offset = "0x2491740", VA = "0x7BBCC91740")]
		private void Start()
		{
		}

		// Token: 0x06003DA0 RID: 15776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DA0")]
		[Address(RVA = "0x2491744", Offset = "0x2491744", VA = "0x7BBCC91744")]
		public void SetClipping()
		{
		}

		// Token: 0x06003DA1 RID: 15777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DA1")]
		[Address(RVA = "0x2491F14", Offset = "0x2491F14", VA = "0x7BBCC91F14")]
		private void RemoveClipping()
		{
		}

		// Token: 0x06003DA2 RID: 15778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DA2")]
		[Address(RVA = "0x24925B8", Offset = "0x24925B8", VA = "0x7BBCC925B8")]
		private void OnWillRenderObject()
		{
		}

		// Token: 0x06003DA3 RID: 15779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DA3")]
		[Address(RVA = "0x2492A00", Offset = "0x2492A00", VA = "0x7BBCC92A00")]
		public SetPanelClip()
		{
		}

		// Token: 0x04004E5C RID: 20060
		[Token(Token = "0x4004E5C")]
		[FieldOffset(Offset = "0x18")]
		private UIPanel panel;

		// Token: 0x04004E5D RID: 20061
		[Token(Token = "0x4004E5D")]
		[FieldOffset(Offset = "0x20")]
		private Shader originalShader;

		// Token: 0x04004E5E RID: 20062
		[Token(Token = "0x4004E5E")]
		[FieldOffset(Offset = "0x28")]
		private Renderer CachedRenderer;

		// Token: 0x04004E5F RID: 20063
		[Token(Token = "0x4004E5F")]
		[FieldOffset(Offset = "0x0")]
		private static int[] LocalToPanelMatrix;

		// Token: 0x04004E60 RID: 20064
		[Token(Token = "0x4004E60")]
		[FieldOffset(Offset = "0x8")]
		private static int[] ClipRange;

		// Token: 0x04004E61 RID: 20065
		[Token(Token = "0x4004E61")]
		[FieldOffset(Offset = "0x10")]
		private static int[] ClipArgs;
	}
}
