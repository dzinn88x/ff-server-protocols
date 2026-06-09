using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001262 RID: 4706
	[Token(Token = "0x2001262")]
	public class EscortVehicleTrackLine : MonoBehaviour
	{
		// Token: 0x060048EB RID: 18667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048EB")]
		[Address(RVA = "0x1B8780C", Offset = "0x1B8780C", VA = "0x7BBC38780C")]
		private void Awake()
		{
		}

		// Token: 0x060048EC RID: 18668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048EC")]
		[Address(RVA = "0x1B8789C", Offset = "0x1B8789C", VA = "0x7BBC38789C")]
		private void Start()
		{
		}

		// Token: 0x060048ED RID: 18669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048ED")]
		[Address(RVA = "0x1B87940", Offset = "0x1B87940", VA = "0x7BBC387940")]
		public void DrawLine()
		{
		}

		// Token: 0x060048EE RID: 18670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048EE")]
		[Address(RVA = "0x1B87B30", Offset = "0x1B87B30", VA = "0x7BBC387B30")]
		public EscortVehicleTrackLine()
		{
		}

		// Token: 0x040071D5 RID: 29141
		[Token(Token = "0x40071D5")]
		[FieldOffset(Offset = "0x18")]
		private bool m_showLaunchLine;

		// Token: 0x040071D6 RID: 29142
		[Token(Token = "0x40071D6")]
		[FieldOffset(Offset = "0x20")]
		public LineRenderer m_LineRender;

		// Token: 0x040071D7 RID: 29143
		[Token(Token = "0x40071D7")]
		private const float interval = 0.2f;

		// Token: 0x040071D8 RID: 29144
		[Token(Token = "0x40071D8")]
		private const int pos_count = 60;

		// Token: 0x040071D9 RID: 29145
		[Token(Token = "0x40071D9")]
		[FieldOffset(Offset = "0x28")]
		public Transform[] m_Positions;
	}
}
