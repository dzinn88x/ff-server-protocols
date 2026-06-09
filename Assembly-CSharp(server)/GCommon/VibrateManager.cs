using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000F6F RID: 3951
	[Token(Token = "0x2000F6F")]
	public class VibrateManager : MonoBehaviour
	{
		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x0600397D RID: 14717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006DD")]
		public static VibrateManager instance
		{
			[Token(Token = "0x600397D")]
			[Address(RVA = "0x22490E4", Offset = "0x22490E4", VA = "0x7BBCA490E4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600397E RID: 14718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600397E")]
		[Address(RVA = "0x224914C", Offset = "0x224914C", VA = "0x7BBCA4914C")]
		private void Awake()
		{
		}

		// Token: 0x0600397F RID: 14719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600397F")]
		[Address(RVA = "0x22491B8", Offset = "0x22491B8", VA = "0x7BBCA491B8")]
		private void Start()
		{
		}

		// Token: 0x06003980 RID: 14720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003980")]
		[Address(RVA = "0x22491BC", Offset = "0x22491BC", VA = "0x7BBCA491BC")]
		private void InitVibrateInfo()
		{
		}

		// Token: 0x06003981 RID: 14721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003981")]
		[Address(RVA = "0x22494D0", Offset = "0x22494D0", VA = "0x7BBCA494D0")]
		public void StartVibrate(VibrateStyle _vibrateStyle, bool _IsLoop = false)
		{
		}

		// Token: 0x06003982 RID: 14722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003982")]
		[Address(RVA = "0x224964C", Offset = "0x224964C", VA = "0x7BBCA4964C")]
		public void StopVibrate()
		{
		}

		// Token: 0x06003983 RID: 14723 RVA: 0x00011D00 File Offset: 0x0000FF00
		[Token(Token = "0x6003983")]
		[Address(RVA = "0x22495AC", Offset = "0x22495AC", VA = "0x7BBCA495AC")]
		private bool isVibrateSupported()
		{
			return default(bool);
		}

		// Token: 0x06003984 RID: 14724 RVA: 0x00011D18 File Offset: 0x0000FF18
		[Token(Token = "0x6003984")]
		[Address(RVA = "0x2249650", Offset = "0x2249650", VA = "0x7BBCA49650")]
		public bool isAsusRogPhone()
		{
			return default(bool);
		}

		// Token: 0x06003985 RID: 14725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003985")]
		[Address(RVA = "0x22496B8", Offset = "0x22496B8", VA = "0x7BBCA496B8")]
		public VibrateManager()
		{
		}

		// Token: 0x04004B13 RID: 19219
		[Token(Token = "0x4004B13")]
		[FieldOffset(Offset = "0x0")]
		private static VibrateManager m_Instance;

		// Token: 0x04004B14 RID: 19220
		[Token(Token = "0x4004B14")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, long[]> vibrateInfoDic;
	}
}
