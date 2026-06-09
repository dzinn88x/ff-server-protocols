using System;
using System.Collections.Generic;
using GCommon.Trails;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000EDD RID: 3805
	[Token(Token = "0x2000EDD")]
	[ExecuteInEditMode]
	[Serializable]
	public class TrailManager : MonoBehaviour
	{
		// Token: 0x060034A7 RID: 13479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034A7")]
		[Address(RVA = "0x249923C", Offset = "0x249923C", VA = "0x7BBCC9923C")]
		private void Start()
		{
		}

		// Token: 0x060034A8 RID: 13480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034A8")]
		[Address(RVA = "0x2499784", Offset = "0x2499784", VA = "0x7BBCC99784")]
		private void LateUpdate()
		{
		}

		// Token: 0x060034A9 RID: 13481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034A9")]
		[Address(RVA = "0x2499E34", Offset = "0x2499E34", VA = "0x7BBCC99E34")]
		private void OnDestroy()
		{
		}

		// Token: 0x060034AA RID: 13482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034AA")]
		[Address(RVA = "0x2499FBC", Offset = "0x2499FBC", VA = "0x7BBCC99FBC")]
		public void AddTrail(Material mat, PCTrail trail)
		{
		}

		// Token: 0x060034AB RID: 13483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034AB")]
		[Address(RVA = "0x2499EA4", Offset = "0x2499EA4", VA = "0x7BBCC99EA4")]
		private void ClearMesh()
		{
		}

		// Token: 0x060034AC RID: 13484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034AC")]
		[Address(RVA = "0x2499D3C", Offset = "0x2499D3C", VA = "0x7BBCC99D3C")]
		private void DrawMesh(Mesh trailMesh, Material trailMaterial)
		{
		}

		// Token: 0x060034AD RID: 13485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034AD")]
		[Address(RVA = "0x249A0D8", Offset = "0x249A0D8", VA = "0x7BBCC9A0D8")]
		public TrailManager()
		{
		}

		// Token: 0x04004850 RID: 18512
		[Token(Token = "0x4004850")]
		[FieldOffset(Offset = "0x18")]
		public TrailRenderer_Base[] Trails;

		// Token: 0x04004851 RID: 18513
		[Token(Token = "0x4004851")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<Material, List<PCTrail>> m_MatToTrailList;

		// Token: 0x04004852 RID: 18514
		[Token(Token = "0x4004852")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<Material, CombineInstance[]> m_CombineInstances;

		// Token: 0x04004853 RID: 18515
		[Token(Token = "0x4004853")]
		[FieldOffset(Offset = "0x30")]
		private readonly int m_CountLimit;

		// Token: 0x04004854 RID: 18516
		[Token(Token = "0x4004854")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<Material, int> m_TrailCountDic;

		// Token: 0x04004855 RID: 18517
		[Token(Token = "0x4004855")]
		[FieldOffset(Offset = "0x40")]
		private Mesh[] combinedMesh;
	}
}
