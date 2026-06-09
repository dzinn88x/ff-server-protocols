using System;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000EAC RID: 3756
	[Token(Token = "0x2000EAC")]
	public class AIWarningRegion<T> : MonoBehaviour, IAIWarningRegion
	{
		// Token: 0x0600336A RID: 13162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600336A")]
		public void InitParam(T initParam)
		{
		}

		// Token: 0x0600336B RID: 13163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600336B")]
		public virtual void OnInit()
		{
		}

		// Token: 0x0600336C RID: 13164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600336C")]
		public GameObject GetGameObject()
		{
			return null;
		}

		// Token: 0x0600336D RID: 13165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600336D")]
		public void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x0600336E RID: 13166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600336E")]
		public void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x0600336F RID: 13167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600336F")]
		public void OnRecycle()
		{
		}

		// Token: 0x06003370 RID: 13168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003370")]
		public AIWarningRegion()
		{
		}

		// Token: 0x06003371 RID: 13169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003371")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x04004783 RID: 18307
		[Token(Token = "0x4004783")]
		[FieldOffset(Offset = "0x0")]
		protected T MyParam;

		// Token: 0x04004784 RID: 18308
		[Token(Token = "0x4004784")]
		[FieldOffset(Offset = "0x0")]
		private Player m_InPlayer;
	}
}
