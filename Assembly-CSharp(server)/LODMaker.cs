using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000190 RID: 400
[Token(Token = "0x2000190")]
public static class LODMaker
{
	// Token: 0x060007F8 RID: 2040 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007F8")]
	[Address(RVA = "0x24D4A44", Offset = "0x24D4A44", VA = "0x7BBCCD4A44")]
	public static Mesh MakeLODMesh(Mesh orig, float aMaxWeight, bool recalcNormals = true, float removeSmallParts = 1f, bool reuseOldMesh = false)
	{
		return null;
	}

	// Token: 0x060007F9 RID: 2041 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007F9")]
	[Address(RVA = "0x24D4AE8", Offset = "0x24D4AE8", VA = "0x7BBCCD4AE8")]
	public static Mesh MakeLODMesh(Mesh orig, float aMaxWeight, float removeSmallParts, float protectNormals, float protectUvs, float smallTrianglesFirst, float protectSubMeshesAndSharpEdges, bool recalcNormals, bool reuseOldMesh = false)
	{
		return null;
	}

	// Token: 0x060007FA RID: 2042 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007FA")]
	[Address(RVA = "0x24D4C88", Offset = "0x24D4C88", VA = "0x7BBCCD4C88")]
	private static void GetWeights(float aMaxWeight, float removeSmallParts, float protectNormals, float protectUvs, float smallTrianglesFirst, float protectSubMeshesAndSharpEdges, out float sideLengthWeight, out float oldAngleWeight, out float newAngleWeight, out float uvWeight, out float areaDiffWeight, out float normalWeight, out float vertexWeight, out float centerDistanceWeight)
	{
	}

	// Token: 0x060007FB RID: 2043 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007FB")]
	[Address(RVA = "0x24D5EC8", Offset = "0x24D5EC8", VA = "0x7BBCCD5EC8")]
	public static void MakeLODMeshInBackground(object data)
	{
	}

	// Token: 0x060007FC RID: 2044 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007FC")]
	[Address(RVA = "0x24D4D2C", Offset = "0x24D4D2C", VA = "0x7BBCCD4D2C")]
	private static Mesh MakeLODMesh(Mesh orig, float maxWeight, float removeSmallParts, float sideLengthWeight, float oldAngleWeight, float newAngleWeight, float uvWeight, float areaDiffWeight, float normalWeight, float vertexWeight, float centerDistanceWeight, bool recalcNormals, bool reuseOldMesh)
	{
		return null;
	}

	// Token: 0x060007FD RID: 2045 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007FD")]
	[Address(RVA = "0x24D7FFC", Offset = "0x24D7FFC", VA = "0x7BBCCD7FFC")]
	private static void MakeLODMesh(Vector3[] vs, Vector3[] ns, Vector2[] uv1s, Vector2[] uv2s, Vector2[] uv3s, Vector2[] uv4s, Color32[] colors32, int[] ts, ref Matrix4x4[] bindposes, BoneWeight[] bws, ref int[] subMeshOffsets, Bounds meshBounds, float maxWeight, float removeSmallParts, float sideLengthWeight, float oldAngleWeight, float newAngleWeight, float uvWeight, float areaDiffWeight, float normalWeight, float vertexWeight, float centerDistanceWeight, out List<Vector3> newVs, out List<Vector3> newNs, out List<Vector2> newUv1s, out List<Vector2> newUv2s, out List<Vector2> newUv3s, out List<Vector2> newUv4s, out List<Color32> newColors32, out List<int> newTs, out List<BoneWeight> newBws)
	{
	}

	// Token: 0x060007FE RID: 2046 RVA: 0x00003858 File Offset: 0x00001A58
	[Token(Token = "0x60007FE")]
	[Address(RVA = "0x24DD668", Offset = "0x24DD668", VA = "0x7BBCCDD668")]
	private static bool AnyWeightOK(float[] weights, float aMaxWeight)
	{
		return default(bool);
	}

	// Token: 0x060007FF RID: 2047 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007FF")]
	[Address(RVA = "0x24DCCA0", Offset = "0x24DCCA0", VA = "0x7BBCCDCCA0")]
	private static int[] GetAdjacentTriangles(int[] ts, int tIdx, List<List<int>> trianglesPerVertex, int[] uniqueVs, int[] triangleGroups, List<List<int>> trianglesPerGroup)
	{
		return null;
	}

	// Token: 0x06000800 RID: 2048 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000800")]
	[Address(RVA = "0x24E25AC", Offset = "0x24E25AC", VA = "0x7BBCCE25AC")]
	private static void SetTriangleGroup(int tIdx0, int tIdx1, int[] triangleGroups, List<List<int>> trianglesPerGroup)
	{
	}

	// Token: 0x06000801 RID: 2049 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000801")]
	[Address(RVA = "0x24DD6EC", Offset = "0x24DD6EC", VA = "0x7BBCCDD6EC")]
	private static void GetTotalAngleAndCenterDistanceForCorner(int[] ts, Vector3[] vs, int[] movedVs, int vertexIdx, Vector3[] centerDistances, ref float totalAngle, ref Vector3 totalCenterDist)
	{
	}

	// Token: 0x06000802 RID: 2050 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000802")]
	[Address(RVA = "0x24DDD64", Offset = "0x24DDD64", VA = "0x7BBCCDDD64")]
	private static void GetTotalAngleAndCenterDistanceForNewCorner(int[] ts, Vector3[] vs, int[] movedVs, int[] uniqueVs, int vertexIdx, int newIdx, Vector3[] centerDistances, float maxWeight, ref float totalAngle, ref Vector3 totalCenterDist, ref bool flipsTriangles)
	{
	}

	// Token: 0x06000803 RID: 2051 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000803")]
	[Address(RVA = "0x24DEC1C", Offset = "0x24DEC1C", VA = "0x7BBCCDEC1C")]
	private static void GetUVStretchAndAreaForCorner(int[] ts, Vector3[] vs, int[] movedVs, int[] uniqueVs, Vector2[] uvs, int cFrom, int cTo, ref float affectedUvAreaDiff, ref float affectedAreaDiff, ref float totalUvAreaDiff, ref float totalAreaDiff)
	{
	}

	// Token: 0x06000804 RID: 2052 RVA: 0x00003870 File Offset: 0x00001A70
	[Token(Token = "0x6000804")]
	[Address(RVA = "0x24DCB80", Offset = "0x24DCB80", VA = "0x7BBCCDCB80")]
	private static float GetNormalDiffForCorners(Vector3[] ns, int corner1, int corner2)
	{
		return 0f;
	}

	// Token: 0x06000805 RID: 2053 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000805")]
	[Address(RVA = "0x24DF9A0", Offset = "0x24DF9A0", VA = "0x7BBCCDF9A0")]
	private static void MergeVertices(ref int oldV, int newV, bool[] hasTwinVS, Vector3[] vs, int[] triangles, Vector2[] uv1s, Vector2[] uv2s, Vector2[] uv3s, Vector2[] uv4s, Color32[] colors32, bool[] deletedVertices, int[] movedVs, int[] uniqueVs, int[] movedUv1s, int[] movedUv2s, int[] movedUv3s, int[] movedUv4s, int[] movedColors, List<List<int>> trianglesPerVertex, bool logYN)
	{
	}

	// Token: 0x06000806 RID: 2054 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000806")]
	[Address(RVA = "0x24E2C0C", Offset = "0x24E2C0C", VA = "0x7BBCCE2C0C")]
	private static void MoveVertex(int oldV, int newV, int[] movedVs, int[] uniqueVs, int[] movedUv1s, int[] movedUv2s, int[] movedUv3s, int[] movedUv4s, int[] movedColors)
	{
	}

	// Token: 0x06000807 RID: 2055 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000807")]
	[Address(RVA = "0x24DFFD0", Offset = "0x24DFFD0", VA = "0x7BBCCDFFD0")]
	private static void FillNewMeshArray(Vector3[] vs, bool[] vdel, int[] movedVs, Vector3[] ns, Vector2[] uv1s, int[] movedUv1s, Vector2[] uv2s, int[] movedUv2s, Vector2[] uv3s, int[] movedUv3s, Vector2[] uv4s, int[] movedUv4s, Color32[] colors32, int[] movedColors, BoneWeight[] bws, List<Vector3> newVs, List<Vector3> newNs, List<Vector2> newUv1s, List<Vector2> newUv2s, List<Vector2> newUv3s, List<Vector2> newUv4s, List<Color32> newColors32, List<BoneWeight> newBws, int[] o2n)
	{
	}

	// Token: 0x06000808 RID: 2056 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000808")]
	[Address(RVA = "0x24E0984", Offset = "0x24E0984", VA = "0x7BBCCE0984")]
	private static void FillNewMeshTriangles(int[] oldTriangles, int[] o2n, List<int> newTriangles, int[] subMeshOffsets, int[] triangleGroups, List<int> newTGrps)
	{
	}

	// Token: 0x06000809 RID: 2057 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000809")]
	[Address(RVA = "0x24E1FA0", Offset = "0x24E1FA0", VA = "0x7BBCCE1FA0")]
	public static void RemoveUnusedVertices(List<Vector3> vs, List<Vector3> ns, List<Vector2> uv1s, List<Vector2> uv2s, List<Vector2> uv3s, List<Vector2> uv4s, List<Color32> colors32, List<BoneWeight> bws, List<int> ts)
	{
	}

	// Token: 0x0600080A RID: 2058 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600080A")]
	[Address(RVA = "0x24E33CC", Offset = "0x24E33CC", VA = "0x7BBCCE33CC")]
	public static void RemoveUnusedVertices(List<Vector3> vs, List<Vector3> ns, List<Vector2> uv1s, List<Vector2> uv2s, List<Vector2> uv3s, List<Vector2> uv4s, List<Color32> colors32, List<BoneWeight> bws, List<List<int>> subMeshes)
	{
	}

	// Token: 0x0600080B RID: 2059 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600080B")]
	[Address(RVA = "0x24E3B88", Offset = "0x24E3B88", VA = "0x7BBCCE3B88")]
	public static void RemoveUnusedVertices(List<Vector3> vs, List<Vector3> ns, List<Vector2> uv1s, List<Vector2> uv2s, List<Vector2> uv3s, List<Vector2> uv4s, List<Color32> colors32, List<BoneWeight> bws, Dictionary<Material, List<int>> subMeshes)
	{
	}

	// Token: 0x0600080C RID: 2060 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600080C")]
	[Address(RVA = "0x24E0EA4", Offset = "0x24E0EA4", VA = "0x7BBCCE0EA4")]
	private static void RemoveEmptyTriangles(List<Vector3> newVs, List<Vector3> newNs, List<Vector2> newUv1s, List<Vector2> newUv2s, List<Vector2> newUv3s, List<Vector2> newUv4s, List<Color32> newColors32, List<int> newTs, List<BoneWeight> newBws, int[] subMeshOffsets, List<int> newTGrps)
	{
	}

	// Token: 0x0600080D RID: 2061 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600080D")]
	[Address(RVA = "0x24E17C4", Offset = "0x24E17C4", VA = "0x7BBCCE17C4")]
	private static void RemoveMiniTriangleGroups(float removeSmallParts, Vector3 sizeMultiplier, float aMaxWeight, List<Vector3> newVs, List<int> newTs, int[] subMeshOffsets, List<int> newTGrps)
	{
	}

	// Token: 0x0600080E RID: 2062 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600080E")]
	[Address(RVA = "0x24DC3E0", Offset = "0x24DC3E0", VA = "0x7BBCCDC3E0")]
	public static Mesh CreateNewMesh(Vector3[] vs, Vector3[] ns, Vector2[] uv1s, Vector2[] uv2s, Vector2[] uv3s, Vector2[] uv4s, Color32[] colors32, int[] ts, BoneWeight[] bws, Matrix4x4[] bindposes, int[] subMeshOffsets, bool recalcNormals)
	{
		return null;
	}

	// Token: 0x0600080F RID: 2063 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600080F")]
	[Address(RVA = "0x24DBF04", Offset = "0x24DBF04", VA = "0x7BBCCDBF04")]
	public static void FillMesh(Mesh mesh, Vector3[] vs, Vector3[] ns, Vector2[] uv1s, Vector2[] uv2s, Vector2[] uv3s, Vector2[] uv4s, Color32[] colors32, int[] ts, BoneWeight[] bws, Matrix4x4[] bindposes, int[] subMeshOffsets, bool recalcNormals)
	{
	}

	// Token: 0x06000810 RID: 2064 RVA: 0x00003888 File Offset: 0x00001A88
	[Token(Token = "0x6000810")]
	[Address(RVA = "0x24DEB48", Offset = "0x24DEB48", VA = "0x7BBCCDEB48")]
	private static float AngleCornerDiff(float angle)
	{
		return 0f;
	}

	// Token: 0x06000811 RID: 2065 RVA: 0x000038A0 File Offset: 0x00001AA0
	[Token(Token = "0x6000811")]
	[Address(RVA = "0x24DDCC0", Offset = "0x24DDCC0", VA = "0x7BBCCDDCC0")]
	private static float AngleDiff(float angle)
	{
		return 0f;
	}

	// Token: 0x06000812 RID: 2066 RVA: 0x000038B8 File Offset: 0x00001AB8
	[Token(Token = "0x6000812")]
	[Address(RVA = "0x24DC9AC", Offset = "0x24DC9AC", VA = "0x7BBCCDC9AC")]
	private static float Area(Vector3 p0, Vector3 p1, Vector3 p2)
	{
		return 0f;
	}

	// Token: 0x06000813 RID: 2067 RVA: 0x000038D0 File Offset: 0x00001AD0
	[Token(Token = "0x6000813")]
	[Address(RVA = "0x24E449C", Offset = "0x24E449C", VA = "0x7BBCCE449C")]
	private static int GetVertexEqualTo(Vector3 v, List<int> orderedVertices, Vector3[] vs)
	{
		return 0;
	}

	// Token: 0x06000814 RID: 2068 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000814")]
	[Address(RVA = "0x24DC7D4", Offset = "0x24DC7D4", VA = "0x7BBCCDC7D4")]
	private static List<int> GetVerticesEqualTo(Vector3 v, List<int> orderedVertices, Vector3[] vs)
	{
		return null;
	}

	// Token: 0x06000815 RID: 2069 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000815")]
	[Address(RVA = "0x24E4788", Offset = "0x24E4788", VA = "0x7BBCCE4788")]
	private static List<int> GetVerticesWithinBox(Vector3 from, Vector3 to, List<int> orderedVertices, Vector3[] vs)
	{
		return null;
	}

	// Token: 0x06000816 RID: 2070 RVA: 0x000038E8 File Offset: 0x00001AE8
	[Token(Token = "0x6000816")]
	[Address(RVA = "0x24DC4DC", Offset = "0x24DC4DC", VA = "0x7BBCCDC4DC")]
	private static int GetLastVertexWithYSmaller(float y, List<int> orderedVertices, Vector3[] vs, int limitSearchRange)
	{
		return 0;
	}

	// Token: 0x06000817 RID: 2071 RVA: 0x00003900 File Offset: 0x00001B00
	[Token(Token = "0x6000817")]
	[Address(RVA = "0x24E4AF4", Offset = "0x24E4AF4", VA = "0x7BBCCE4AF4")]
	private static bool IsVertexObscured(Vector3[] vs, Vector3[] ns, int[] ts, bool[] vObscured, int[] uniqueVs, Vector3 vertexBoxSize, List<int> orderedVertices, List<List<int>> trianglesPerVertex, int[] subMeshIdxPerVertex, float maxObscureDist, bool hiddenByOtherSubmesh, Vector3 vertex, Vector3 normal, int i)
	{
		return default(bool);
	}

	// Token: 0x06000818 RID: 2072 RVA: 0x00003918 File Offset: 0x00001B18
	[Token(Token = "0x6000818")]
	[Address(RVA = "0x24E5558", Offset = "0x24E5558", VA = "0x7BBCCE5558")]
	public static float FindCollision(Vector3 fromPos, Vector3 direction, Vector3 pointOnPlane, Vector3 normalPlane)
	{
		return 0f;
	}

	// Token: 0x06000819 RID: 2073 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000819")]
	[Address(RVA = "0x24E56A0", Offset = "0x24E56A0", VA = "0x7BBCCE56A0")]
	private static void LogVectors(string msg, int[] idxs, Vector3[] vs, int decimals)
	{
	}

	// Token: 0x0600081A RID: 2074 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600081A")]
	[Address(RVA = "0x24E5B2C", Offset = "0x24E5B2C", VA = "0x7BBCCE5B2C")]
	private static void LogArray(string msg, List<Vector3> vs, int decimals)
	{
	}

	// Token: 0x0600081B RID: 2075 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600081B")]
	[Address(RVA = "0x24E5F98", Offset = "0x24E5F98", VA = "0x7BBCCE5F98")]
	private static void LogArray(string msg, Vector3[] vs, int decimals)
	{
	}

	// Token: 0x0600081C RID: 2076 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600081C")]
	[Address(RVA = "0x24E63E8", Offset = "0x24E63E8", VA = "0x7BBCCE63E8")]
	private static void LogArray(string msg, Vector2[] vs, int decimals)
	{
	}

	// Token: 0x0600081D RID: 2077 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600081D")]
	[Address(RVA = "0x24E6828", Offset = "0x24E6828", VA = "0x7BBCCE6828")]
	private static void LogTriArray(string msg, List<int> ts)
	{
	}

	// Token: 0x0600081E RID: 2078 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600081E")]
	[Address(RVA = "0x24E6D80", Offset = "0x24E6D80", VA = "0x7BBCCE6D80")]
	private static void LogTriArray(string msg, int[] ts)
	{
	}

	// Token: 0x0600081F RID: 2079 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600081F")]
	[Address(RVA = "0x24E72CC", Offset = "0x24E72CC", VA = "0x7BBCCE72CC")]
	private static void LogArray(string msg, List<Color32> ts)
	{
	}

	// Token: 0x06000820 RID: 2080 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000820")]
	[Address(RVA = "0x24E7588", Offset = "0x24E7588", VA = "0x7BBCCE7588")]
	private static void LogArray(string msg, Color32[] ts)
	{
	}

	// Token: 0x06000821 RID: 2081 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000821")]
	[Address(RVA = "0x24E7818", Offset = "0x24E7818", VA = "0x7BBCCE7818")]
	private static void LogArray(string msg, List<int> ts)
	{
	}

	// Token: 0x06000822 RID: 2082 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000822")]
	[Address(RVA = "0x24E7ACC", Offset = "0x24E7ACC", VA = "0x7BBCCE7ACC")]
	private static void LogArray(string msg, List<List<int>> ts)
	{
	}

	// Token: 0x06000823 RID: 2083 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000823")]
	[Address(RVA = "0x24E7E10", Offset = "0x24E7E10", VA = "0x7BBCCE7E10")]
	private static void LogArray(string msg, int[] ts)
	{
	}

	// Token: 0x06000824 RID: 2084 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000824")]
	[Address(RVA = "0x24E8098", Offset = "0x24E8098", VA = "0x7BBCCE8098")]
	private static void LogArray(string msg, float[] fs)
	{
	}

	// Token: 0x06000825 RID: 2085 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000825")]
	[Address(RVA = "0x24E8328", Offset = "0x24E8328", VA = "0x7BBCCE8328")]
	private static void LogArray(string msg, bool[] ts)
	{
	}

	// Token: 0x06000826 RID: 2086 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000826")]
	[Address(RVA = "0x24E85A8", Offset = "0x24E85A8", VA = "0x7BBCCE85A8")]
	private static string LogWeights(string msg, float[] w)
	{
		return null;
	}

	// Token: 0x06000827 RID: 2087 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000827")]
	[Address(RVA = "0x24DBE10", Offset = "0x24DBE10", VA = "0x7BBCCDBE10")]
	private static void Log(string msg)
	{
	}

	// Token: 0x0400083A RID: 2106
	[Token(Token = "0x400083A")]
	[FieldOffset(Offset = "0x0")]
	public static int[] EmptyTriangleArr;
}
