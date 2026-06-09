using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x020028E4 RID: 10468
	[Token(Token = "0x20028E4")]
	public class PickupTreasureBox : MonoBehaviour
	{
		// Token: 0x0600DDB8 RID: 56760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDB8")]
		[Address(RVA = "0x12E091C", Offset = "0x12E091C", VA = "0x7BBBAE091C")]
		private void Start()
		{
		}

		// Token: 0x0600DDB9 RID: 56761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDB9")]
		[Address(RVA = "0x12E098C", Offset = "0x12E098C", VA = "0x7BBBAE098C")]
		public void SyncStatus(bool I\u0080m|aZV = false)
		{
		}

		// Token: 0x0600DDBA RID: 56762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDBA")]
		[Address(RVA = "0x12E0B00", Offset = "0x12E0B00", VA = "0x7BBBAE0B00")]
		public PickupTreasureBox()
		{
		}

		// Token: 0x04010DBF RID: 69055
		[Token(Token = "0x4010DBF")]
		[FieldOffset(Offset = "0x18")]
		public GameObject VFX_TreasureEffect;

		// Token: 0x04010DC0 RID: 69056
		[Token(Token = "0x4010DC0")]
		[FieldOffset(Offset = "0x20")]
		public GameObject TreasureBoxModel;

		// Token: 0x04010DC1 RID: 69057
		[Token(Token = "0x4010DC1")]
		[FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public bool m_IsDiggedOut;
	}
}
