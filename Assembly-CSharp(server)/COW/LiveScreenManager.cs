using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020012CC RID: 4812
	[Token(Token = "0x20012CC")]
	public class LiveScreenManager : MonoBehaviour
	{
		// Token: 0x06004BB5 RID: 19381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BB5")]
		[Address(RVA = "0x1405040", Offset = "0x1405040", VA = "0x7BBBC05040")]
		protected void OnEnable()
		{
		}

		// Token: 0x06004BB6 RID: 19382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BB6")]
		[Address(RVA = "0x14052CC", Offset = "0x14052CC", VA = "0x7BBBC052CC")]
		protected void OnDisable()
		{
		}

		// Token: 0x06004BB7 RID: 19383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BB7")]
		[Address(RVA = "0x1405368", Offset = "0x1405368", VA = "0x7BBBC05368")]
		public LiveScreenManager()
		{
		}

		// Token: 0x040073A1 RID: 29601
		[Token(Token = "0x40073A1")]
		[FieldOffset(Offset = "0x18")]
		public GameObject m_LiveCamera;

		// Token: 0x040073A2 RID: 29602
		[Token(Token = "0x40073A2")]
		[FieldOffset(Offset = "0x20")]
		public GameObject m_LiveScreen;

		// Token: 0x040073A3 RID: 29603
		[Token(Token = "0x40073A3")]
		[FieldOffset(Offset = "0x28")]
		private RenderTexture m_CameraTargetTxture;
	}
}
