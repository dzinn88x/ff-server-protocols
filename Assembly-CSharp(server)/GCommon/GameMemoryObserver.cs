using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000F24 RID: 3876
	[Token(Token = "0x2000F24")]
	public class GameMemoryObserver : MonoBehaviour
	{
		// Token: 0x06003757 RID: 14167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003757")]
		[Address(RVA = "0x21196C8", Offset = "0x21196C8", VA = "0x7BBC9196C8")]
		private void Awake()
		{
		}

		// Token: 0x06003758 RID: 14168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003758")]
		[Address(RVA = "0x2119734", Offset = "0x2119734", VA = "0x7BBC919734")]
		private void Start()
		{
		}

		// Token: 0x06003759 RID: 14169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003759")]
		[Address(RVA = "0x2119744", Offset = "0x2119744", VA = "0x7BBC919744")]
		private void Update()
		{
		}

		// Token: 0x0600375A RID: 14170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600375A")]
		[Address(RVA = "0x21197A4", Offset = "0x21197A4", VA = "0x7BBC9197A4")]
		private void LogAvailMemory()
		{
		}

		// Token: 0x0600375B RID: 14171 RVA: 0x000112E0 File Offset: 0x0000F4E0
		[Token(Token = "0x600375B")]
		[Address(RVA = "0x21197F4", Offset = "0x21197F4", VA = "0x7BBC9197F4")]
		public int GetMinAvailMemory()
		{
			return 0;
		}

		// Token: 0x0600375C RID: 14172 RVA: 0x000112F8 File Offset: 0x0000F4F8
		[Token(Token = "0x600375C")]
		[Address(RVA = "0x21197FC", Offset = "0x21197FC", VA = "0x7BBC9197FC")]
		public int GetMaxAvailMemory()
		{
			return 0;
		}

		// Token: 0x0600375D RID: 14173 RVA: 0x00011310 File Offset: 0x0000F510
		[Token(Token = "0x600375D")]
		[Address(RVA = "0x2119804", Offset = "0x2119804", VA = "0x7BBC919804")]
		public int GetCurrentAvailMemory()
		{
			return 0;
		}

		// Token: 0x0600375E RID: 14174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600375E")]
		[Address(RVA = "0x211980C", Offset = "0x211980C", VA = "0x7BBC91980C")]
		public void StartLogMemory()
		{
		}

		// Token: 0x0600375F RID: 14175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600375F")]
		[Address(RVA = "0x2119840", Offset = "0x2119840", VA = "0x7BBC919840")]
		public void StopLogMemory()
		{
		}

		// Token: 0x06003760 RID: 14176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003760")]
		[Address(RVA = "0x2119848", Offset = "0x2119848", VA = "0x7BBC919848")]
		public GameMemoryObserver()
		{
		}

		// Token: 0x040049F6 RID: 18934
		[Token(Token = "0x40049F6")]
		[FieldOffset(Offset = "0x0")]
		public static GameMemoryObserver instance;

		// Token: 0x040049F7 RID: 18935
		[Token(Token = "0x40049F7")]
		[FieldOffset(Offset = "0x18")]
		private bool needLogMemory;

		// Token: 0x040049F8 RID: 18936
		[Token(Token = "0x40049F8")]
		[FieldOffset(Offset = "0x1C")]
		public float logAvailMemoryInterval;

		// Token: 0x040049F9 RID: 18937
		[Token(Token = "0x40049F9")]
		[FieldOffset(Offset = "0x20")]
		public float logAvailMemoryTimer;

		// Token: 0x040049FA RID: 18938
		[Token(Token = "0x40049FA")]
		[FieldOffset(Offset = "0x24")]
		private int currentMemory;

		// Token: 0x040049FB RID: 18939
		[Token(Token = "0x40049FB")]
		[FieldOffset(Offset = "0x28")]
		private int maxMemory;

		// Token: 0x040049FC RID: 18940
		[Token(Token = "0x40049FC")]
		[FieldOffset(Offset = "0x2C")]
		private int minMemory;
	}
}
