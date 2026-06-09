using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02001035 RID: 4149
	[Token(Token = "0x2001035")]
	[Attribute(Name = "RequireComponent", RVA = "0x10EA794", Offset = "0x10EA794")]
	public class UIMultiresolutionFit : MonoBehaviour
	{
		// Token: 0x06003EEA RID: 16106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EEA")]
		[Address(RVA = "0x2031334", Offset = "0x2031334", VA = "0x7BBC831334")]
		private void Awake()
		{
		}

		// Token: 0x06003EEB RID: 16107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EEB")]
		[Address(RVA = "0x2031338", Offset = "0x2031338", VA = "0x7BBC831338")]
		private void Start()
		{
		}

		// Token: 0x06003EEC RID: 16108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EEC")]
		[Address(RVA = "0x203135C", Offset = "0x203135C", VA = "0x7BBC83135C")]
		private void Init()
		{
		}

		// Token: 0x06003EED RID: 16109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EED")]
		[Address(RVA = "0x20317F4", Offset = "0x20317F4", VA = "0x7BBC8317F4")]
		private void OnUIRootChange()
		{
		}

		// Token: 0x06003EEE RID: 16110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EEE")]
		[Address(RVA = "0x20316A0", Offset = "0x20316A0", VA = "0x7BBC8316A0")]
		private void CalcFullScreenNguiSize()
		{
		}

		// Token: 0x06003EEF RID: 16111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EEF")]
		[Address(RVA = "0x20318B0", Offset = "0x20318B0", VA = "0x7BBC8318B0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06003EF0 RID: 16112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EF0")]
		[Address(RVA = "0x20314C0", Offset = "0x20314C0", VA = "0x7BBC8314C0")]
		public void FitSize()
		{
		}

		// Token: 0x06003EF1 RID: 16113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EF1")]
		[Address(RVA = "0x203197C", Offset = "0x203197C", VA = "0x7BBC83197C")]
		public UIMultiresolutionFit()
		{
		}

		// Token: 0x04004F24 RID: 20260
		[Token(Token = "0x4004F24")]
		[FieldOffset(Offset = "0x18")]
		public int sourceAspectWidth;

		// Token: 0x04004F25 RID: 20261
		[Token(Token = "0x4004F25")]
		[FieldOffset(Offset = "0x1C")]
		public int sourceAspectHight;

		// Token: 0x04004F26 RID: 20262
		[Token(Token = "0x4004F26")]
		[FieldOffset(Offset = "0x20")]
		public bool showTop;

		// Token: 0x04004F27 RID: 20263
		[Token(Token = "0x4004F27")]
		[FieldOffset(Offset = "0x24")]
		private float sourceAspect;

		// Token: 0x04004F28 RID: 20264
		[Token(Token = "0x4004F28")]
		[FieldOffset(Offset = "0x28")]
		private bool baseOnWidth;

		// Token: 0x04004F29 RID: 20265
		[Token(Token = "0x4004F29")]
		[FieldOffset(Offset = "0x30")]
		private UIWidget widget;

		// Token: 0x04004F2A RID: 20266
		[Token(Token = "0x4004F2A")]
		[FieldOffset(Offset = "0x38")]
		private bool init;

		// Token: 0x04004F2B RID: 20267
		[Token(Token = "0x4004F2B")]
		[FieldOffset(Offset = "0x3C")]
		private Vector2 screenSize;

		// Token: 0x04004F2C RID: 20268
		[Token(Token = "0x4004F2C")]
		[FieldOffset(Offset = "0x44")]
		private Vector2 fullScreenNguiSize;

		// Token: 0x04004F2D RID: 20269
		[Token(Token = "0x4004F2D")]
		[FieldOffset(Offset = "0x50")]
		private UIRoot uiRoot;

		// Token: 0x04004F2E RID: 20270
		[Token(Token = "0x4004F2E")]
		[FieldOffset(Offset = "0x58")]
		private float lastScreenRatio;

		// Token: 0x04004F2F RID: 20271
		[Token(Token = "0x4004F2F")]
		[FieldOffset(Offset = "0x5C")]
		private int lastUIRootWidth;
	}
}
