using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02001005 RID: 4101
	[Token(Token = "0x2001005")]
	public class MaskShaderController : MonoBehaviour
	{
		// Token: 0x06003D6F RID: 15727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D6F")]
		[Address(RVA = "0x212C2A4", Offset = "0x212C2A4", VA = "0x7BBC92C2A4")]
		private void Awake()
		{
		}

		// Token: 0x06003D70 RID: 15728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D70")]
		[Address(RVA = "0x212C3C0", Offset = "0x212C3C0", VA = "0x7BBC92C3C0")]
		private void OnDisable()
		{
		}

		// Token: 0x06003D71 RID: 15729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D71")]
		[Address(RVA = "0x212C3C8", Offset = "0x212C3C8", VA = "0x7BBC92C3C8")]
		private void OnEnable()
		{
		}

		// Token: 0x06003D72 RID: 15730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D72")]
		[Address(RVA = "0x212C3D0", Offset = "0x212C3D0", VA = "0x7BBC92C3D0")]
		public void Update()
		{
		}

		// Token: 0x06003D73 RID: 15731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D73")]
		[Address(RVA = "0x212C8AC", Offset = "0x212C8AC", VA = "0x7BBC92C8AC")]
		public MaskShaderController()
		{
		}

		// Token: 0x04004E2E RID: 20014
		[Token(Token = "0x4004E2E")]
		[FieldOffset(Offset = "0x18")]
		private float wr;

		// Token: 0x04004E2F RID: 20015
		[Token(Token = "0x4004E2F")]
		[FieldOffset(Offset = "0x1C")]
		private float hr;

		// Token: 0x04004E30 RID: 20016
		[Token(Token = "0x4004E30")]
		[FieldOffset(Offset = "0x20")]
		private float offX;

		// Token: 0x04004E31 RID: 20017
		[Token(Token = "0x4004E31")]
		[FieldOffset(Offset = "0x24")]
		private float offY;

		// Token: 0x04004E32 RID: 20018
		[Token(Token = "0x4004E32")]
		[FieldOffset(Offset = "0x28")]
		private Texture2D tex;

		// Token: 0x04004E33 RID: 20019
		[Token(Token = "0x4004E33")]
		[FieldOffset(Offset = "0x30")]
		private bool setmask;
	}
}
