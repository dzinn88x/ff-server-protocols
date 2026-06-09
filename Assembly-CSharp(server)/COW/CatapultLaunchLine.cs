using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001261 RID: 4705
	[Token(Token = "0x2001261")]
	public class CatapultLaunchLine : MonoBehaviour
	{
		// Token: 0x060048E7 RID: 18663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048E7")]
		[Address(RVA = "0x14F3DF0", Offset = "0x14F3DF0", VA = "0x7BBBCF3DF0")]
		private void Start()
		{
		}

		// Token: 0x060048E8 RID: 18664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048E8")]
		[Address(RVA = "0x14F3EA8", Offset = "0x14F3EA8", VA = "0x7BBBCF3EA8")]
		private void Update()
		{
		}

		// Token: 0x060048E9 RID: 18665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048E9")]
		[Address(RVA = "0x14F4218", Offset = "0x14F4218", VA = "0x7BBBCF4218")]
		private void DrawLine(Vector3 throwPos, Vector3 throwVel, Vector3 gravity)
		{
		}

		// Token: 0x060048EA RID: 18666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048EA")]
		[Address(RVA = "0x14F43BC", Offset = "0x14F43BC", VA = "0x7BBBCF43BC")]
		public CatapultLaunchLine()
		{
		}

		// Token: 0x040071D2 RID: 29138
		[Token(Token = "0x40071D2")]
		[FieldOffset(Offset = "0x18")]
		private LineRenderer m_LineRender;

		// Token: 0x040071D3 RID: 29139
		[Token(Token = "0x40071D3")]
		private const float interval = 0.2f;

		// Token: 0x040071D4 RID: 29140
		[Token(Token = "0x40071D4")]
		private const int pos_count = 60;
	}
}
