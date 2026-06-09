using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001269 RID: 4713
	[Token(Token = "0x2001269")]
	public class FerrisWheelSeatGroup : MonoBehaviour
	{
		// Token: 0x060048FE RID: 18686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048FE")]
		[Address(RVA = "0x1B95998", Offset = "0x1B95998", VA = "0x7BBC395998")]
		private void Awake()
		{
		}

		// Token: 0x060048FF RID: 18687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048FF")]
		[Address(RVA = "0x1B95A40", Offset = "0x1B95A40", VA = "0x7BBC395A40")]
		private void LateUpdate()
		{
		}

		// Token: 0x06004900 RID: 18688 RVA: 0x00016200 File Offset: 0x00014400
		[Token(Token = "0x6004900")]
		[Address(RVA = "0x1B95AA0", Offset = "0x1B95AA0", VA = "0x7BBC395AA0")]
		public bool CanGetOn()
		{
			return default(bool);
		}

		// Token: 0x06004901 RID: 18689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004901")]
		[Address(RVA = "0x1B95B30", Offset = "0x1B95B30", VA = "0x7BBC395B30")]
		public FerrisWheelSeatGroup()
		{
		}

		// Token: 0x040071EC RID: 29164
		[Token(Token = "0x40071EC")]
		[FieldOffset(Offset = "0x18")]
		private bool m_EnableSeatRota;

		// Token: 0x040071ED RID: 29165
		[Token(Token = "0x40071ED")]
		[FieldOffset(Offset = "0x20")]
		public Transform RotationCenter;

		// Token: 0x040071EE RID: 29166
		[Token(Token = "0x40071EE")]
		[FieldOffset(Offset = "0x28")]
		public FerrisWheelSeat[] Seat;

		// Token: 0x040071EF RID: 29167
		[Token(Token = "0x40071EF")]
		[FieldOffset(Offset = "0x30")]
		public byte GroupID;

		// Token: 0x040071F0 RID: 29168
		[Token(Token = "0x40071F0")]
		[FieldOffset(Offset = "0x34")]
		public uint FerrisWheelID;

		// Token: 0x040071F1 RID: 29169
		[Token(Token = "0x40071F1")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 oriWorldRota;
	}
}
