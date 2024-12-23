package com.example.alunos.repository;

import com.example.alunos.model.Aluno;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import java.util.Optional;
@Repository
public interface AlunoRepository extends JpaRepository<Aluno, Long> {

}
