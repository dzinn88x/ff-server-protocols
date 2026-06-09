using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020025AE RID: 9646
	[Token(Token = "0x20025AE")]
	public class SpectatorAirDropObject : MonoBehaviour
	{
		// Token: 0x17000CCD RID: 3277
		// (get) Token: 0x0600C67A RID: 50810 RVA: 0x00035460 File Offset: 0x00033660
		// (set) Token: 0x0600C679 RID: 50809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CCD")]
		public bool Active
		{
			[Token(Token = "0x600C67A")]
			[Address(RVA = "0x1B3F200", Offset = "0x1B3F200", VA = "0x7BBC33F200")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600C679")]
			[Address(RVA = "0x1B3F0F4", Offset = "0x1B3F0F4", VA = "0x7BBC33F0F4")]
			set
			{
			}
		}

		// Token: 0x17000CCE RID: 3278
		// (get) Token: 0x0600C67C RID: 50812 RVA: 0x00035478 File Offset: 0x00033678
		// (set) Token: 0x0600C67B RID: 50811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CCE")]
		public Vector3 Scale
		{
			[Token(Token = "0x600C67C")]
			[Address(RVA = "0x1B3F264", Offset = "0x1B3F264", VA = "0x7BBC33F264")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600C67B")]
			[Address(RVA = "0x1B3F208", Offset = "0x1B3F208", VA = "0x7BBC33F208")]
			set
			{
			}
		}

		// Token: 0x17000CCF RID: 3279
		// (get) Token: 0x0600C67E RID: 50814 RVA: 0x00035490 File Offset: 0x00033690
		// (set) Token: 0x0600C67D RID: 50813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CCF")]
		public Vector3 Position
		{
			[Token(Token = "0x600C67E")]
			[Address(RVA = "0x1B3F2F4", Offset = "0x1B3F2F4", VA = "0x7BBC33F2F4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600C67D")]
			[Address(RVA = "0x1B3F298", Offset = "0x1B3F298", VA = "0x7BBC33F298")]
			set
			{
			}
		}

		// Token: 0x0600C67F RID: 50815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C67F")]
		[Address(RVA = "0x1B3F328", Offset = "0x1B3F328", VA = "0x7BBC33F328")]
		public void SetIndex(int index)
		{
		}

		// Token: 0x0600C680 RID: 50816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C680")]
		[Address(RVA = "0x1B3F3E4", Offset = "0x1B3F3E4", VA = "0x7BBC33F3E4")]
		public void SetPostion(Vector3 pos)
		{
		}

		// Token: 0x0600C681 RID: 50817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C681")]
		[Address(RVA = "0x1B3F4BC", Offset = "0x1B3F4BC", VA = "0x7BBC33F4BC")]
		private void OnGotoClick()
		{
		}

		// Token: 0x0600C682 RID: 50818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C682")]
		[Address(RVA = "0x1B3F6A0", Offset = "0x1B3F6A0", VA = "0x7BBC33F6A0")]
		public SpectatorAirDropObject()
		{
		}

		// Token: 0x0400F907 RID: 63751
		[Token(Token = "0x400F907")]
		private const uint AIRDROP_COLOR_ACTIVE = 4290380031U;

		// Token: 0x0400F908 RID: 63752
		[Token(Token = "0x400F908")]
		private const uint AIRDROP_COLOR_DISACTIVE = 2812782591U;

		// Token: 0x0400F909 RID: 63753
		[Token(Token = "0x400F909")]
		[FieldOffset(Offset = "0x18")]
		public UISprite AirDropSprite;

		// Token: 0x0400F90A RID: 63754
		[Token(Token = "0x400F90A")]
		[FieldOffset(Offset = "0x20")]
		public UILabel IndexLadel;

		// Token: 0x0400F90B RID: 63755
		[Token(Token = "0x400F90B")]
		[FieldOffset(Offset = "0x28")]
		public UIButton GotoBtn;

		// Token: 0x0400F90C RID: 63756
		[Token(Token = "0x400F90C")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 m_Pos;

		// Token: 0x0400F90D RID: 63757
		[Token(Token = "0x400F90D")]
		[FieldOffset(Offset = "0x3C")]
		private int m_Index;

		// Token: 0x0400F90E RID: 63758
		[Token(Token = "0x400F90E")]
		[FieldOffset(Offset = "0x40")]
		private bool m_IsActive;
	}
}
