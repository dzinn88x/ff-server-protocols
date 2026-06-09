using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x020028DB RID: 10459
	[Token(Token = "0x20028DB")]
	[ExecuteInEditMode]
	[Attribute(Name = "RequireComponent", RVA = "0x10FEC74", Offset = "0x10FEC74")]
	public class LineMovePlatformController : MovePlatformController
	{
		// Token: 0x0600DD8C RID: 56716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD8C")]
		[Address(RVA = "0x1996EEC", Offset = "0x1996EEC", VA = "0x7BBC196EEC")]
		private void Start()
		{
		}

		// Token: 0x0600DD8D RID: 56717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD8D")]
		[Address(RVA = "0x19970E8", Offset = "0x19970E8", VA = "0x7BBC1970E8")]
		public void ResetMoveInEdiotr(bool Z\u0082X\u0082p~])
		{
		}

		// Token: 0x0600DD8E RID: 56718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD8E")]
		[Address(RVA = "0x1997490", Offset = "0x1997490", VA = "0x7BBC197490")]
		private void Update()
		{
		}

		// Token: 0x0600DD8F RID: 56719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD8F")]
		[Address(RVA = "0x1997494", Offset = "0x1997494", VA = "0x7BBC197494")]
		public void UpdateClientMove()
		{
		}

		// Token: 0x0600DD90 RID: 56720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD90")]
		[Address(RVA = "0x1997B88", Offset = "0x1997B88", VA = "0x7BBC197B88")]
		public void CreateMoveData()
		{
		}

		// Token: 0x0600DD91 RID: 56721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD91")]
		[Address(RVA = "0x1997EAC", Offset = "0x1997EAC", VA = "0x7BBC197EAC")]
		public void RefreshPathNode()
		{
		}

		// Token: 0x0600DD92 RID: 56722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD92")]
		[Address(RVA = "0x1996FD8", Offset = "0x1996FD8", VA = "0x7BBC196FD8")]
		public void ClearAll()
		{
		}

		// Token: 0x0600DD93 RID: 56723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD93")]
		[Address(RVA = "0x1998170", Offset = "0x1998170", VA = "0x7BBC198170")]
		public void ClearMovePlatform()
		{
		}

		// Token: 0x0600DD94 RID: 56724 RVA: 0x0003D500 File Offset: 0x0003B700
		[Token(Token = "0x600DD94")]
		[Address(RVA = "0x1997ABC", Offset = "0x1997ABC", VA = "0x7BBC197ABC")]
		public Quaternion LookRotation(Vector3 fYz`NBT)
		{
			return default(Quaternion);
		}

		// Token: 0x0600DD95 RID: 56725 RVA: 0x0003D518 File Offset: 0x0003B718
		[Token(Token = "0x600DD95")]
		[Address(RVA = "0x199832C", Offset = "0x199832C", VA = "0x7BBC19832C")]
		private Quaternion LcWuQrO(Vector3 UIjBnlQ, Vector3 SsKF[Bd)
		{
			return default(Quaternion);
		}

		// Token: 0x0600DD96 RID: 56726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD96")]
		[Address(RVA = "0x1998688", Offset = "0x1998688", VA = "0x7BBC198688")]
		public LineMovePlatformController()
		{
		}

		// Token: 0x04010D88 RID: 69000
		[Token(Token = "0x4010D88")]
		[FieldOffset(Offset = "0x18")]
		public List<LineMovePlatformController.MoveData> moveDataList;

		// Token: 0x04010D89 RID: 69001
		[Token(Token = "0x4010D89")]
		[FieldOffset(Offset = "0x20")]
		private bool \u0081kGlkb{;

		// Token: 0x020028DC RID: 10460
		[Token(Token = "0x20028DC")]
		[Serializable]
		public class MoveData
		{
			// Token: 0x0600DD97 RID: 56727 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DD97")]
			[Address(RVA = "0x1997E34", Offset = "0x1997E34", VA = "0x7BBC197E34")]
			public MoveData()
			{
			}

			// Token: 0x04010D8A RID: 69002
			[Token(Token = "0x4010D8A")]
			[FieldOffset(Offset = "0x10")]
			public Transform m_MovePlatform;

			// Token: 0x04010D8B RID: 69003
			[Token(Token = "0x4010D8B")]
			[FieldOffset(Offset = "0x18")]
			public float m_MoveSpeed;

			// Token: 0x04010D8C RID: 69004
			[Token(Token = "0x4010D8C")]
			[FieldOffset(Offset = "0x1C")]
			public bool m_IsNeedLoop;

			// Token: 0x04010D8D RID: 69005
			[Token(Token = "0x4010D8D")]
			[FieldOffset(Offset = "0x1D")]
			public bool m_IsFaceToFoward;

			// Token: 0x04010D8E RID: 69006
			[Token(Token = "0x4010D8E")]
			[FieldOffset(Offset = "0x20")]
			public float m_RotSpeed;

			// Token: 0x04010D8F RID: 69007
			[Token(Token = "0x4010D8F")]
			[FieldOffset(Offset = "0x24")]
			public bool m_IsHitKillPlayer;

			// Token: 0x04010D90 RID: 69008
			[Token(Token = "0x4010D90")]
			[FieldOffset(Offset = "0x25")]
			public bool EndToTurn;

			// Token: 0x04010D91 RID: 69009
			[Token(Token = "0x4010D91")]
			[FieldOffset(Offset = "0x28")]
			public List<Transform> m_MoveLine;

			// Token: 0x04010D92 RID: 69010
			[Token(Token = "0x4010D92")]
			[FieldOffset(Offset = "0x30")]
			[HideInInspector]
			public int curTargetNodeIndex;

			// Token: 0x04010D93 RID: 69011
			[Token(Token = "0x4010D93")]
			[FieldOffset(Offset = "0x34")]
			[HideInInspector]
			public bool isMovingForward;

			// Token: 0x04010D94 RID: 69012
			[Token(Token = "0x4010D94")]
			[FieldOffset(Offset = "0x35")]
			[HideInInspector]
			public bool isArrive;

			// Token: 0x04010D95 RID: 69013
			[Token(Token = "0x4010D95")]
			[FieldOffset(Offset = "0x38")]
			[HideInInspector]
			public Vector3 curMoveDirection;

			// Token: 0x04010D96 RID: 69014
			[Token(Token = "0x4010D96")]
			[FieldOffset(Offset = "0x48")]
			[HideInInspector]
			public Transform pathNodeRoot;
		}
	}
}
